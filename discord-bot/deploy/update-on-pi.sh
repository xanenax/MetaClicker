#!/usr/bin/env bash
set -Eeuo pipefail

REPO_DIR="/home/xanenax/metaclicker-repo"
BOT_DIR="$REPO_DIR/discord-bot"
RUNTIME_DIR="/home/xanenax/metaclicker-bot"
ENV_FILE="$RUNTIME_DIR/.env"
DATA_DIR="$RUNTIME_DIR/data"
LOG_FILE="$RUNTIME_DIR/deploy.log"
CONTAINER_NAME="metaclicker-bot"
IMAGE_NAME="metaclicker-bot:latest"
ROLLBACK_IMAGE="metaclicker-bot:rollback"

mkdir -p "$RUNTIME_DIR" "$DATA_DIR"
exec 9>"/tmp/metaclicker-bot-update.lock"
flock -n 9 || exit 0

log() {
  printf '[%s] %s\n' "$(date --iso-8601=seconds)" "$*" >> "$LOG_FILE"
}

cd "$REPO_DIR"
git fetch --quiet origin main

current_commit="$(git rev-parse HEAD)"
target_commit="$(git rev-parse origin/main)"

if [[ "$current_commit" == "$target_commit" ]]; then
  exit 0
fi

bot_changed=1
if git diff --quiet "$current_commit" "$target_commit" -- discord-bot; then
  bot_changed=0
fi

git reset --hard --quiet "$target_commit"

if [[ "$bot_changed" -eq 0 ]]; then
  log "Repository updated to ${target_commit:0:8}; no bot changes."
  exit 0
fi

log "Bot update ${current_commit:0:8} -> ${target_commit:0:8} started."

if docker image inspect "$IMAGE_NAME" >/dev/null 2>&1; then
  docker image tag "$IMAGE_NAME" "$ROLLBACK_IMAGE"
fi

docker build --quiet -t "$IMAGE_NAME" "$BOT_DIR" >/dev/null
docker run --rm "$IMAGE_NAME" node --check src/index.js

if docker container inspect "$CONTAINER_NAME" >/dev/null 2>&1; then
  docker rm -f "$CONTAINER_NAME" >/dev/null
fi

start_container() {
  docker run -d \
    --name "$CONTAINER_NAME" \
    --restart unless-stopped \
    --env-file "$ENV_FILE" \
    -v "$DATA_DIR:/app/data" \
    "$1" >/dev/null
}

start_container "$IMAGE_NAME"
sleep 8

if [[ "$(docker inspect -f '{{.State.Running}}' "$CONTAINER_NAME")" != "true" ]]; then
  log "New container failed; rolling back."
  docker rm -f "$CONTAINER_NAME" >/dev/null 2>&1 || true
  start_container "$ROLLBACK_IMAGE"
  exit 1
fi

log "Bot update deployed successfully."
