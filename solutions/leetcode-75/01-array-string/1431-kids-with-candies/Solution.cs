public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int maxCandies = candies.Max();
        var result = new List<bool>(candies.Length);
        foreach (int c in candies)
            result.Add(c + extraCandies >= maxCandies);
        return result;
    }
}
