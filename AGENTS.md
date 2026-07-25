# MetaClicker workspace guidance

- Assume the user may be away from the computer.
- When progress is genuinely blocked and user input or a manual action is required, send the server owner a concise Discord DM before ending the turn:

  ```powershell
  Set-Location discord-bot
  npm run notify-owner -- "Explain the exact action needed and mention the current Codex task."
  ```

- Do not send notifications for optional questions or normal progress updates.
- Never print, inspect, commit, or include the Discord token in messages, logs, screenshots, or commands.
