# MetaClicker

[![Build](https://github.com/xanenax/MetaClicker/actions/workflows/build.yml/badge.svg)](https://github.com/xanenax/MetaClicker/actions/workflows/build.yml)
[![Website](https://img.shields.io/badge/Website-GitHub%20Pages-8b3dff)](https://xanenax.github.io/MetaClicker/)

MetaClicker ist ein modernisiertes Open-Source-Autoclicker-Projekt für Windows.
Das Projekt verbindet den Charakter der ursprünglichen Anwendung mit einer
erneuerten technischen Basis, einem einheitlichen Schwarz-Violett-Design und
einer transparenten Entwicklung auf GitHub.

Der Name **Meta** und das bekannte Logo bleiben erhalten. MetaClicker wird als
offenes Spaßprojekt weiterentwickelt – ohne HWID-Prüfung, ohne externe
Freigabeliste und mit nachvollziehbaren Versionen.

## Funktionen

- getrennte Einstellungen für Links- und Rechtsklick
- frei wählbare Hotkeys
- anpassbare Standard-Akzentfarbe
- weicher RGB-Modus, der bei der Standardfarbe beginnt
- vollständig lokaler Start ohne Online-Login
- reproduzierbare Windows-x64-Builds

## Download

Die aktuelle Windows-Version steht unter
[GitHub Releases](https://github.com/xanenax/MetaClicker/releases/latest) bereit.

## Selbst bauen

Benötigt werden Windows, Visual Studio mit der Workload
**.NET-Desktopentwicklung** und das .NET Framework 4.8 Developer Pack.

1. `MetaClicker.sln` in Visual Studio öffnen.
2. Oben `Release` auswählen.
3. **Erstellen → Projektmappe erstellen** anklicken.
4. Die fertige Datei liegt in `MetaClicker/bin/Release/MetaClicker.exe`.

Alternativ über eine Developer PowerShell:

```powershell
nuget restore MetaClicker.sln
msbuild MetaClicker.sln /p:Configuration=Release
```

## Mitmachen

Fehlerberichte, Ideen und Verbesserungen sind willkommen. Eine einfache
deutschsprachige Git-Anleitung steht in
[GIT-ANLEITUNG.md](GIT-ANLEITUNG.md).

## Technischer Hinweis

Das Projekt enthält ältere UI-Komponenten, die im 64-Bit-Modus am stabilsten
laufen. Deshalb ist MetaClicker bewusst auf Windows x64 eingestellt.
