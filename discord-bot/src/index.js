import {
  ActivityType,
  Client,
  EmbedBuilder,
  Events,
  GatewayIntentBits,
  MessageFlags,
  PermissionFlagsBits,
  SlashCommandBuilder,
} from "discord.js";
import { config, validateConfig } from "./config.js";
import {
  accentColor,
  findManagedChannel,
  findManagedRole,
  setupServer,
} from "./server-layout.js";
import { handleWordle } from "./wordle.js";

validateConfig();

const commands = [
  new SlashCommandBuilder()
    .setName("wordle")
    .setDescription("Play the daily five-letter Wordle.")
    .addSubcommand((subcommand) =>
      subcommand
        .setName("start")
        .setDescription("Start or reopen today’s Wordle."),
    )
    .addSubcommand((subcommand) =>
      subcommand
        .setName("guess")
        .setDescription("Submit a five-letter guess.")
        .addStringOption((option) =>
          option
            .setName("word")
            .setDescription("Your five-letter guess")
            .setRequired(true)
            .setMinLength(5)
            .setMaxLength(5),
        ),
    )
    .addSubcommand((subcommand) =>
      subcommand
        .setName("status")
        .setDescription("Show today’s current board."),
    )
    .addSubcommand((subcommand) =>
      subcommand
        .setName("give-up")
        .setDescription("End today’s game and reveal the answer."),
    ),
  new SlashCommandBuilder()
    .setName("setup")
    .setDescription("Create or repair the XANENAX MetaClicker server layout.")
    .setDefaultMemberPermissions(PermissionFlagsBits.ManageGuild),
].map((command) => command.toJSON());

const client = new Client({
  intents: [GatewayIntentBits.Guilds, GatewayIntentBits.GuildMembers],
});

let shuttingDown = false;

client.once(Events.ClientReady, async (readyClient) => {
  console.log(`Logged in as ${readyClient.user.tag}`);
  readyClient.user.setActivity("MetaClicker • /wordle", {
    type: ActivityType.Playing,
  });

  const guild = await readyClient.guilds.fetch(config.guildId);
  const fullGuild = await guild.fetch();
  await fullGuild.commands.set(commands);
  console.log(`Registered commands in ${fullGuild.name}`);

  if (config.autoSetup) {
    await setupServer(fullGuild, config);
    console.log(`Server setup complete for ${fullGuild.name}`);
  }
});

client.on(Events.GuildMemberAdd, async (member) => {
  try {
    const memberRole = findManagedRole(member.guild, "Member");
    if (memberRole?.editable) {
      await member.roles.add(memberRole, "Automatic member role");
    }

    const welcomeChannel = findManagedChannel(member.guild, "welcome");
    if (welcomeChannel?.isTextBased()) {
      await welcomeChannel.send({
        content: `${member}`,
        embeds: [
          new EmbedBuilder()
            .setColor(accentColor)
            .setTitle("Welcome to XANENAX • MetaClicker")
            .setDescription(
              `Welcome, ${member}! Get the official build in **#downloads**, read **#rules**, and ask questions in **#support**.`,
            )
            .setThumbnail(member.user.displayAvatarURL({ size: 256 }))
            .setFooter({
              text: `Member ${member.guild.memberCount}`,
            })
            .setTimestamp(),
        ],
      });
    }

    const joinLog = findManagedChannel(member.guild, "join-log");
    if (joinLog?.isTextBased()) {
      await joinLog.send({
        embeds: [
          new EmbedBuilder()
            .setColor(accentColor)
            .setTitle("Member joined")
            .setDescription(`${member.user.tag} (${member.id})`)
            .addFields({
              name: "Account created",
              value: `<t:${Math.floor(member.user.createdTimestamp / 1000)}:R>`,
            })
            .setThumbnail(member.user.displayAvatarURL({ size: 128 }))
            .setTimestamp(),
        ],
      });
    }
  } catch (error) {
    console.error("Could not process member join:", error);
  }
});

client.on(Events.InteractionCreate, async (interaction) => {
  if (!interaction.isChatInputCommand() || !interaction.inGuild()) {
    return;
  }

  try {
    if (interaction.commandName === "wordle") {
      await handleWordle(interaction);
      return;
    }

    if (interaction.commandName === "setup") {
      await interaction.deferReply({ flags: MessageFlags.Ephemeral });
      await setupServer(interaction.guild, config);
      await interaction.editReply(
        "Server setup complete. Existing unrelated channels were left untouched.",
      );
    }
  } catch (error) {
    console.error(`Command ${interaction.commandName} failed:`, error);
    const response = {
      content:
        "Something went wrong while running that command. Check the bot console for details.",
      flags: MessageFlags.Ephemeral,
    };

    if (interaction.deferred || interaction.replied) {
      await interaction.followUp(response);
    } else {
      await interaction.reply(response);
    }
  }
});

client.on(Events.Error, (error) => {
  console.error("Discord client error:", error);
});

async function shutdown(signal) {
  if (shuttingDown) {
    return;
  }

  shuttingDown = true;
  console.log(`Received ${signal}; disconnecting.`);
  client.destroy();
  process.exit(0);
}

process.on("SIGINT", () => shutdown("SIGINT"));
process.on("SIGTERM", () => shutdown("SIGTERM"));

client.login(config.token);
