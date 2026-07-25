$ErrorActionPreference = 'Continue'
$botDirectory = Split-Path -Parent $MyInvocation.MyCommand.Path
$logDirectory = Join-Path $botDirectory 'logs'
$mutex = [Threading.Mutex]::new($false, 'Local\XANENAXMetaClickerBotWatchdog')

if (-not $mutex.WaitOne(0, $false)) {
    exit 0
}

New-Item -ItemType Directory -Path $logDirectory -Force | Out-Null
Set-Location -LiteralPath $botDirectory

try {
    while ($true) {
        $timestamp = Get-Date -Format 'yyyy-MM-dd HH:mm:ss'
        Add-Content -LiteralPath (Join-Path $logDirectory 'watchdog.log') -Value "[$timestamp] Starting bot."

        & node 'src/index.js' 1>> (Join-Path $logDirectory 'bot.stdout.log') 2>> (Join-Path $logDirectory 'bot.stderr.log')

        $exitCode = $LASTEXITCODE
        $timestamp = Get-Date -Format 'yyyy-MM-dd HH:mm:ss'
        Add-Content -LiteralPath (Join-Path $logDirectory 'watchdog.log') -Value "[$timestamp] Bot exited with code $exitCode. Restarting in 5 seconds."
        Start-Sleep -Seconds 5
    }
}
finally {
    $mutex.ReleaseMutex()
    $mutex.Dispose()
}
