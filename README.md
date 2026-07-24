# MetaClicker

[![Build](https://github.com/xanenax/MetaClicker/actions/workflows/build.yml/badge.svg)](https://github.com/xanenax/MetaClicker/actions/workflows/build.yml)

MetaClicker ist ein klassischer Windows-Autoclicker, der aus einem älteren
.NET-Framework-Projekt wieder lauffähig gemacht wurde. Das Programm unterstützt
getrennte Einstellungen für Links- und Rechtsklicks, Hotkeys und eine anpassbare
Oberfläche.

## Aktueller Stand

- Windows x64
- .NET Framework 4.8
- HWID- und Pastefy-Abhängigkeit entfernt
- kurzer lokaler Startbildschirm statt Online-Login
- reproduzierbare Debug- und Release-Builds

## Download

Fertige Versionen werden künftig unter
[Releases](https://github.com/xanenax/MetaClicker/releases) veröffentlicht.

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

## Projektseite

Die kleine Projektseite wird nach der Aktivierung von GitHub Pages unter
[xanenax.github.io/MetaClicker](https://xanenax.github.io/MetaClicker/) erreichbar
sein.

## Änderungen speichern

Eine einfache deutschsprachige Anleitung für den täglichen Git-Ablauf steht in
[GIT-ANLEITUNG.md](GIT-ANLEITUNG.md).

## Hinweis

Dieses Repository enthält ältere UI-Komponenten, die nur im 64-Bit-Modus stabil
funktionieren. Deshalb ist das Projekt bewusst auf x64 eingestellt.
