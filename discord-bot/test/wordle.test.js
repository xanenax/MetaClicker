import assert from "node:assert/strict";
import test from "node:test";
import { getDailyAnswer, scoreGuess } from "../src/wordle.js";
import { ANSWERS } from "../src/words.js";

test("scores exact matches", () => {
  assert.deepEqual(scoreGuess("CRANE", "CRANE"), [
    "correct",
    "correct",
    "correct",
    "correct",
    "correct",
  ]);
});

test("handles duplicate letters without over-counting", () => {
  assert.deepEqual(scoreGuess("APPLE", "ALLEY"), [
    "correct",
    "present",
    "absent",
    "present",
    "absent",
  ]);
});

test("uses one stable answer for a UTC date", () => {
  const first = getDailyAnswer("2026-07-25");
  const second = getDailyAnswer("2026-07-25");

  assert.equal(first, second);
  assert.match(first, /^[A-Z]{5}$/);
});

test("contains only valid five-letter answers", () => {
  assert.equal(ANSWERS.length, new Set(ANSWERS).size);
  assert.equal(ANSWERS.every((word) => /^[a-z]{5}$/.test(word)), true);
});
