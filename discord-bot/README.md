# XANENAX MetaClicker Bot

Custom Discord bot for the XANENAX community, with MetaClicker as the main focus.

## Included

- automatic server setup with roles, categories, text channels, and voice channels
- public welcome messages and private join logs
- automatic `Member` role for new users
- daily Wordle through `/wordle`
- safe, repeatable `/setup` command that only creates or updates managed items
- official MetaClicker and YouTube links

## Commands

- `/wordle start`
- `/wordle guess word:crane`
- `/wordle status`
- `/wordle give-up`
- `/setup` — server managers only

## Local setup

1. Copy `.env.example` to `.env`.
2. Add the bot token, application ID, and server ID.
3. Enable the **Server Members Intent** in the Discord Developer Portal.
4. Install dependencies with `npm install`.
5. Start the bot with `npm start`.

The `.env` file and Wordle save data are ignored by Git. Never post the bot token in Discord, GitHub, screenshots, or chat messages.

The bot runs while this process is active. Permanent 24/7 operation requires a host or a computer that stays online.

To send the server owner a private Discord notification when Codex needs help:

```powershell
npm run notify-owner -- "Please open the current Codex task."
```
