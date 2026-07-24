# Git-Anleitung für MetaClicker

Git speichert nicht automatisch jeden Tastendruck. Du bestimmst selbst, wann ein
sinnvoller Zwischenstand als **Commit** gespeichert wird. GitHub bewahrt diese
Commits zusätzlich online auf.

## Der normale Ablauf

Öffne im Projektordner ein Terminal und führe diese vier Befehle aus:

```powershell
git status
git add .
git commit -m "Kurze Beschreibung meiner Änderung"
git push
```

Beispiel:

```powershell
git add .
git commit -m "Geschwindigkeitseinstellung verbessert"
git push
```

Das bedeuten die Befehle:

1. `git status` zeigt, was geändert wurde.
2. `git add .` nimmt die Änderungen in den nächsten Speicherstand auf.
3. `git commit -m "..."` erstellt den lokalen Speicherstand.
4. `git push` lädt ihn zu GitHub hoch.

## Verlauf ansehen

```powershell
git log --oneline
```

In Visual Studio findest du denselben Verlauf unter **Git → Repository verwalten**
beziehungsweise im Fenster **Git-Repository**.

## Eine alte Version ansehen

Kopiere zuerst die kurze Nummer aus `git log --oneline` und verwende:

```powershell
git switch --detach DEINE_COMMIT_NUMMER
```

Zur aktuellen Version kommst du zurück mit:

```powershell
git switch main
```

Im `detach`-Modus solltest du nichts weiterentwickeln. Er ist nur zum Anschauen
oder Testen eines alten Stands gedacht.

## Vor Änderungen immer aktualisieren

Falls das Projekt später von mehreren Rechnern bearbeitet wird:

```powershell
git pull
```

Danach wie gewohnt ändern, `git add .`, `git commit` und `git push` ausführen.

## Versionsnummer markieren

Für eine wichtige fertige Version kannst du einen Tag anlegen:

```powershell
git tag v1.0.1
git push origin v1.0.1
```

Tags sollten nur für getestete Versionen verwendet werden.

## Wenn etwas unklar ist

Nicht raten und keine Dateien aus `.git` löschen. Du kannst Codex einfach sagen:

> Speichere meinen aktuellen Stand mit Git und pushe ihn.

Dann kann der Status vorher geprüft und ein sinnvoller Commit erstellt werden.
