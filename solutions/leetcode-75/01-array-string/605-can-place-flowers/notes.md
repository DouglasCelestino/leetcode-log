# 605. Can Place Flowers

**Difficulty:** Easy

## Concepts
- Greedy
- In-place array mutation
- Boundary handling (virtual zeros outside the array)

## Learnings
- Planting as early as possible is optimal: taking a valid slot never blocks a later slot that a
  different choice could have used, so a single left-to-right pass gives the maximum count
- Treating the positions before index `0` and after the last index as empty (`0`) removes the need
  for special cases at the edges — the same three-cell check works everywhere
- Writing `1` back into `flowerbed[i]` is what makes the greedy correct: the next iteration reads
  the updated value as its `prev`, so two adjacent slots can never both be taken
- Time O(n), auxiliary space O(1) — the input array is reused as the state

## Mistakes on the First Attempt
- Named the counter `n_available` (snake_case) and the helper `adjacentNum` (camelCase), both
  against the C# conventions of this repository: locals are `camelCase`, methods are `PascalCase`
- Wrote the helper as returning `int` (`1`/`0`) and compared it with `== 1`. The function answers a
  yes/no question, so the return type should be `bool` and the call reads as the condition itself
- Left a stray `;` after the closing brace of the `if` block — harmless, but it is an empty statement
