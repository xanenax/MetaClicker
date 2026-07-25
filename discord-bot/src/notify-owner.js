import { REST, Routes } from "discord.js";
import { config, validateConfig } from "./config.js";

validateConfig();

const message =
  process.argv.slice(2).join(" ").trim() ||
  "Codex needs your help with the MetaClicker project. Please open the current Codex task.";

if (message.length > 1_900) {
  throw new Error("Notification text must be 1,900 characters or fewer.");
}

const rest = new REST({ version: "10" }).setToken(config.token);
const guild = await rest.get(Routes.guild(config.guildId));
const dmChannel = await rest.post(Routes.userChannels(), {
  body: { recipient_id: guild.owner_id },
});

await rest.post(Routes.channelMessages(dmChannel.id), {
  body: { content: `🔔 **Codex needs you**\n${message}` },
});

console.log("Owner notification sent.");
