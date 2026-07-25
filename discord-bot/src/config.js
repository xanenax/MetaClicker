import "dotenv/config";

function readBoolean(value, fallback) {
  if (value == null || value.trim() === "") {
    return fallback;
  }

  return value.trim().toLowerCase() === "true";
}

export const config = Object.freeze({
  token: process.env.DISCORD_TOKEN?.trim() ?? "",
  clientId: process.env.DISCORD_CLIENT_ID?.trim() ?? "",
  guildId: process.env.DISCORD_GUILD_ID?.trim() ?? "",
  autoSetup: readBoolean(process.env.AUTO_SETUP, true),
  serverName: process.env.SERVER_NAME?.trim() || "XANENAX • MetaClicker",
  youtubeUrl:
    process.env.YOUTUBE_URL?.trim() ||
    "https://www.youtube.com/@xanenax2.0",
  releaseUrl:
    process.env.RELEASE_URL?.trim() ||
    "https://github.com/xanenax/MetaClicker/releases/latest",
});

export function validateConfig() {
  const missing = [];

  if (!config.token) {
    missing.push("DISCORD_TOKEN");
  }

  if (!config.clientId) {
    missing.push("DISCORD_CLIENT_ID");
  }

  if (!config.guildId) {
    missing.push("DISCORD_GUILD_ID");
  }

  if (missing.length > 0) {
    throw new Error(
      `Missing ${missing.join(", ")}. Copy .env.example to .env and fill in the local values.`,
    );
  }
}
