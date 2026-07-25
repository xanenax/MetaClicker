import { REST, Routes } from "discord.js";
import { config, validateConfig } from "./config.js";

validateConfig();

const message =
  process.argv.slice(2).join(" ").trim() ||
  "Codex needs your help with the MetaClicker project. Please open the current Codex task.";

if (message.length > 1_800) {
  throw new Error("Notification text must be 1,800 characters or fewer.");
}

const rest = new REST({ version: "10" }).setToken(config.token);
const guild = await rest.get(Routes.guild(config.guildId));
const dmChannel = await rest.post(Routes.userChannels(), {
  body: { recipient_id: guild.owner_id },
});

const notificationPrefix = "🔔 **Codex update**";
const managedPrefixes = [
  notificationPrefix,
  "🔔 **Codex needs you**",
];
const sentMessage = await rest.post(Routes.channelMessages(dmChannel.id), {
  body: {
    content: `${notificationPrefix} • <@${guild.owner_id}>\n${message}`,
    allowed_mentions: {
      parse: [],
      users: [guild.owner_id],
      roles: [],
      replied_user: false,
    },
  },
});

const recentMessages = await rest.get(Routes.channelMessages(dmChannel.id), {
  query: new URLSearchParams({ limit: "50" }),
});

const oldNotifications = recentMessages.filter(
  (candidate) =>
    candidate.id !== sentMessage.id &&
    candidate.author.id === sentMessage.author.id &&
    managedPrefixes.some((prefix) => candidate.content.startsWith(prefix)),
);

for (const oldNotification of oldNotifications) {
  await rest.delete(
    Routes.channelMessage(dmChannel.id, oldNotification.id),
  );
}

console.log(
  `Owner notification sent; removed ${oldNotifications.length} older notification(s).`,
);
