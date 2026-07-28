# 1071. Greatest Common Divisor of Strings

**Difficulty:** Easy

## Concepts
- GCD (Greatest Common Divisor)
- String Repetition

## Learnings
- Relating the GCD of two numbers to the length of strings that repeat to form larger strings
- Using the Euclidean Algorithm to optimize the GCD calculation

## Mistakes on the First Attempt
- Confused the GCD of strings with finding a common substring

## Alternative Approach
A GCD string exists if and only if `str1 + str2 == str2 + str1`. When the two concatenations are
equal, the answer is `str1[0..gcd(len1, len2)]`; otherwise it is the empty string. This replaces
building the repeated strings with a single comparison, while the GCD of the lengths is still needed
to slice the answer. Recorded here as an alternative for study — the implementation in `Solution.cs`
is the explicit repetition check.
