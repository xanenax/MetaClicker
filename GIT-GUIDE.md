# Git guide

Git saves intentional project snapshots called **commits**. GitHub keeps those
snapshots online.

## Save an update

Run these commands in the project folder:

```powershell
git status
git add .
git commit -m "Describe the update"
git push
```

Use one commit for one meaningful update. Tiny visual corrections can stay
together in the same commit.

## Update before working

```powershell
git pull
```

## View the history

```powershell
git log --oneline
```

To inspect an older snapshot:

```powershell
git switch --detach COMMIT_ID
```

Return to the current version:

```powershell
git switch main
```

Do not edit or delete files inside `.git`. If anything is unclear, ask Codex to
check the repository and save the current state.
