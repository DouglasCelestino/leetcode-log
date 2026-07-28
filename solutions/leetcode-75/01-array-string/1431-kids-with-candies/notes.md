# 1431. Kids With the Greatest Number of Candies

**Difficulty:** Easy

## Concepts
- Linear scan
- Auxiliary space vs. output space

## Learnings
- Two linear passes stay O(n), not O(n^2): finding the maximum and then comparing each element are sequential passes, not nested ones
- Pre-sizing `List<bool>` with the known length avoids internal reallocations

## Mistakes on the First Attempt
- Tried to reduce space complexity by reusing the input array. Two errors there — the input is `int[]` and the return type is `IList<bool>`, so the buffer is not reusable; and more importantly, the O(n) output is mandated by the problem, not overhead. Auxiliary space here is O(1) (a single int). The interview answer is "O(1) auxiliary space; the O(n) output is required by the problem statement."
