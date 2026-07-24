# MetaClicker

[![Build](https://github.com/xanenax/MetaClicker/actions/workflows/build.yml/badge.svg)](https://github.com/xanenax/MetaClicker/actions/workflows/build.yml)
[![Website](https://img.shields.io/badge/Website-GitHub%20Pages-8b3dff)](https://xanenax.github.io/MetaClicker/)

A compact, free and open-source Windows autoclicker built for Minecraft.

## Features

- separate left- and right-click settings
- configurable hotkeys and CPS
- number-key hotbar slot detection
- optional Blockhit and Shift behavior
- local startup without an account or HWID check

## Project story

MetaClicker started years ago as a personal project on an aging WinForms
codebase. It eventually stopped building, depended on an external HWID list,
and no longer felt like something worth sharing.

In 2026 I brought it into Codex, repaired the build, removed the online login,
fixed the RGB and layout issues, and redesigned the app and website from the
ground up. The code is still intentionally simple and old-school—but it works
again, and every release is now tracked openly with Git.

## Download

Get the latest Windows x64 build from
[GitHub Releases](https://github.com/xanenax/MetaClicker/releases/latest).

## Build

Install Visual Studio with **.NET desktop development** and the .NET Framework
4.8 Developer Pack. Open `MetaClicker.sln`, select `Release`, and build the
solution.

Developer PowerShell:

```powershell
nuget restore MetaClicker.sln
msbuild MetaClicker.sln /p:Configuration=Release
```

The executable is written to `MetaClicker/bin/Release/MetaClicker.exe`.

New to Git? See [GIT-GUIDE.md](GIT-GUIDE.md).
