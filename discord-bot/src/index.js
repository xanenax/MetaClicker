import {
  ActivityType,
  AttachmentBuilder,
  Client,
  EmbedBuilder,
  Events,
  GatewayIntentBits,
  MessageFlags,
  PermissionFlagsBits,
  SlashCommandBuilder,
} from "discord.js";
import { fileURLToPath } from "node:url";
import { config, validateConfig } from "./config.js";
import {
  accentColor,
  findManagedChannel,
  findManagedRole,
  setupServer,
} from "./server-layout.js";
import { handleWordle } from "./wordle.js";

const welcomeBannerPath = fileURLToPath(
  new URL("../assets/welcome-banner.png", import.meta.url),
);

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
    const joinedChannel = findManagedChannel(member.guild, "joined");
    if (joinedChannel?.isTextBased()) {
      const banner = new AttachmentBuilder(welcomeBannerPath, {
        name: "welcome-banner.png",
      });

      await joinedChannel.send({
        content: `${member}`,
        files: [banner],
        embeds: [
          new EmbedBuilder()
            .setColor(accentColor)
            .setTitle("Welcome to XANENAX • MetaClicker")
            .setDescription(
              `Glad you are here, ${member}. Head to **#verify** to unlock the server and join the MetaClicker community.`,
            )
            .setThumbnail(member.user.displayAvatarURL({ size: 256 }))
            .setImage("attachment://welcome-banner.png")
            .setFooter({
              text: `Member #${member.guild.memberCount}`,
            })
            .setTimestamp(),
        ],
      });
    }
  } catch (error) {
    console.error("Could not process member join:", error);
  }
});

client.on(Events.InteractionCreate, async (interaction) => {
  if (!interaction.inGuild()) {
    return;
  }

  try {
    if (interaction.isButton() && interaction.customId === "verify_member") {
      const memberRole = findManagedRole(interaction.guild, "Member");
      const member = await interaction.guild.members.fetch(interaction.user.id);

      if (!memberRole?.editable) {
        await interaction.reply({
          content: "Verification is temporarily unavailable. Please contact staff.",
          flags: MessageFlags.Ephemeral,
        });
        return;
      }

      if (member.roles.cache.has(memberRole.id)) {
        await interaction.reply({
          content: "You are already verified.",
          flags: MessageFlags.Ephemeral,
        });
        return;
      }

      await member.roles.add(memberRole, "Verified through #verify");
      await interaction.reply({
        content: "Verified — welcome! The rest of the server is now unlocked.",
        flags: MessageFlags.Ephemeral,
      });
      return;
    }

    if (!interaction.isChatInputCommand()) {
      return;
    }

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
