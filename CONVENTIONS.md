# Conventions

Rules for this repository. Follow them exactly — they exist to stop the structure from drifting.

**Folder layout:** `solutions/leetcode-75/<NN-category>/<id>-<slug>/`
Every problem folder contains exactly two files: `Solution.cs` and `notes.md`.
Categories with no solved problems keep a `.gitkeep` so the folder still exists.

**notes.md sections,** in this order: title (`# <id>. <Problem Name>`), `**Difficulty:**`,
`## Concepts`, `## Learnings`, `## Mistakes on the First Attempt`.

**C# naming:** locals are `camelCase`, methods are `PascalCase`. No `snake_case`.

**Hard rule: the solution files and the `tracking.md` update go in the SAME commit.
Never commit a solution without updating `tracking.md`.**

**Commit message format:** `feat: add <Problem Name> (<id>) solution`

**Category choice:** the category must match the official LeetCode 75 plan, not intuition about
which technique the problem seems to use. A problem solved with two pointers can still belong to
Array/String — check the plan, not the approach.
