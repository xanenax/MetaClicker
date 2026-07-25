import fs from "node:fs";
import path from "node:path";
import { fileURLToPath } from "node:url";
import { EmbedBuilder, MessageFlags } from "discord.js";
import { ANSWERS } from "./words.js";

const MODULE_DIR = path.dirname(fileURLToPath(import.meta.url));
const DATA_FILE = path.resolve(MODULE_DIR, "../data/games.json");
const MAX_ATTEMPTS = 6;
const EMPTY_ROW = "⬛⬛⬛⬛⬛";

function todayUtc() {
  return new Date().toISOString().slice(0, 10);
}

function stableHash(value) {
  let hash = 2166136261;

  for (const character of value) {
    hash ^= character.charCodeAt(0);
    hash = Math.imul(hash, 16777619);
  }

  return hash >>> 0;
}

export function getDailyAnswer(dateKey = todayUtc()) {
  return ANSWERS[stableHash(dateKey) % ANSWERS.length].toUpperCase();
}

export function scoreGuess(answerValue, guessValue) {
  const answer = answerValue.toUpperCase().split("");
  const guess = guessValue.toUpperCase().split("");
  const result = Array(5).fill("absent");
  const remaining = new Map();

  for (let index = 0; index < 5; index += 1) {
    if (guess[index] === answer[index]) {
      result[index] = "correct";
      continue;
    }

    remaining.set(answer[index], (remaining.get(answer[index]) ?? 0) + 1);
  }

  for (let index = 0; index < 5; index += 1) {
    if (result[index] === "correct") {
      continue;
    }

    const available = remaining.get(guess[index]) ?? 0;
    if (available > 0) {
      result[index] = "present";
      remaining.set(guess[index], available - 1);
    }
  }

  return result;
}

function renderScore(score) {
  return score
    .map((value) => {
      if (value === "correct") {
        return "🟩";
      }

      if (value === "present") {
        return "🟨";
      }

      return "⬛";
    })
    .join("");
}

function renderBoard(game, answer) {
  const rows = game.guesses.map((guess) =>
    renderScore(scoreGuess(answer, guess)),
  );

  while (rows.length < MAX_ATTEMPTS) {
    rows.push(EMPTY_ROW);
  }

  return rows.join("\n");
}

function gameKey(guildId, userId, dateKey) {
  return `${guildId}:${userId}:${dateKey}`;
}

function loadGames() {
  try {
    return JSON.parse(fs.readFileSync(DATA_FILE, "utf8"));
  } catch (error) {
    if (error.code === "ENOENT") {
      return {};
    }

    throw error;
  }
}

function saveGames(games) {
  fs.mkdirSync(path.dirname(DATA_FILE), { recursive: true });
  const temporaryFile = `${DATA_FILE}.tmp`;
  fs.writeFileSync(temporaryFile, `${JSON.stringify(games, null, 2)}\n`);
  fs.renameSync(temporaryFile, DATA_FILE);
}

function getOrCreateGame(games, guildId, userId, dateKey) {
  const key = gameKey(guildId, userId, dateKey);

  if (!games[key]) {
    games[key] = {
      guesses: [],
      status: "playing",
      updatedAt: new Date().toISOString(),
    };
  }

  return { key, game: games[key] };
}

function buildEmbed(game, answer, dateKey, message) {
  const finished = game.status !== "playing";
  const color =
    game.status === "won"
      ? 0x57f287
      : game.status === "lost"
        ? 0xed4245
        : 0x9235ff;

  const embed = new EmbedBuilder()
    .setColor(color)
    .setTitle(`XANENAX Wordle • ${dateKey}`)
    .setDescription(`${renderBoard(game, answer)}\n\n${message}`)
    .setFooter({
      text: finished
        ? `Answer: ${answer}`
        : `${game.guesses.length}/${MAX_ATTEMPTS} attempts`,
    });

  if (game.guesses.length > 0) {
    embed.addFields({
      name: "Guesses",
      value: game.guesses.map((guess) => `\`${guess}\``).join(" "),
    });
  }

  return embed;
}

function normalizeGuess(value) {
  return value.trim().toUpperCase();
}

export async function handleWordle(interaction) {
  const dateKey = todayUtc();
  const answer = getDailyAnswer(dateKey);
  const games = loadGames();
  const { game } = getOrCreateGame(
    games,
    interaction.guildId,
    interaction.user.id,
    dateKey,
  );
  const subcommand = interaction.options.getSubcommand();
  let message = "Use `/wordle guess` and enter a five-letter word.";

  if (subcommand === "guess") {
    if (game.status !== "playing") {
      message =
        game.status === "won"
          ? "You already solved today’s Wordle."
          : "Today’s game is already over. A new word arrives tomorrow.";
    } else {
      const guess = normalizeGuess(
        interaction.options.getString("word", true),
      );

      if (!/^[A-Z]{5}$/.test(guess)) {
        await interaction.reply({
          content: "Enter exactly five English letters.",
          flags: MessageFlags.Ephemeral,
        });
        return;
      }

      if (game.guesses.includes(guess)) {
        await interaction.reply({
          content: `You already tried \`${guess}\`.`,
          flags: MessageFlags.Ephemeral,
        });
        return;
      }

      game.guesses.push(guess);

      if (guess === answer) {
        game.status = "won";
        message = `Solved in ${game.guesses.length}/${MAX_ATTEMPTS}. Nice.`;
      } else if (game.guesses.length >= MAX_ATTEMPTS) {
        game.status = "lost";
        message = "No attempts left. Try again tomorrow.";
      } else {
        message = `${MAX_ATTEMPTS - game.guesses.length} attempts left.`;
      }
    }
  } else if (subcommand === "give-up") {
    if (game.status === "playing") {
      game.status = "lost";
      message = "Game ended. A new word arrives tomorrow.";
    }
  } else if (subcommand === "status" && game.guesses.length === 0) {
    message = "No guesses yet. Use `/wordle guess` to begin.";
  }

  game.updatedAt = new Date().toISOString();
  saveGames(games);

  await interaction.reply({
    embeds: [buildEmbed(game, answer, dateKey, message)],
    flags: MessageFlags.Ephemeral,
  });
}
