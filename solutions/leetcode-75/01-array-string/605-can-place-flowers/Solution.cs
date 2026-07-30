public class Solution {
    private static bool CanPlant(int prev, int current, int next) {
        return prev == 0 && current == 0 && next == 0;
    }

    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int planted = 0;
        for (int i = 0; i < flowerbed.Length; i++) {
            int prev = i == 0 ? 0 : flowerbed[i - 1];
            int next = i == flowerbed.Length - 1 ? 0 : flowerbed[i + 1];
            if (CanPlant(prev, flowerbed[i], next)) {
                flowerbed[i] = 1;
                planted++;
            }
        }
        return planted >= n;
    }
}
