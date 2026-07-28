# 1768. Merge Strings Alternately

**Difficulty:** Easy

## Concepts
- Two Pointers
- StringBuilder with pre-allocated capacity
- Range operator (`word[j..len]`)

## Learnings
- Pre-sizing `StringBuilder` with `len1 + len2` avoids internal buffer reallocations
- After iterating up to `Math.Min(len1, len2)`, the remaining suffix of the longer string can be appended in a single call instead of continuing character by character

## Mistakes on the First Attempt
- First attempt used `+=` string concatenation inside the loop, which is O(n^2) due to reallocations; replaced with `StringBuilder`
