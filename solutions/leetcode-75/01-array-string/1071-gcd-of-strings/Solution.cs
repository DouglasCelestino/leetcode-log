public class Solution {
    public int GreatestCommonDivisor(int len1, int len2){
        while (len2 != 0){
            int temp = len2;
            len2 = len1 % len2;
            len1 = temp;
        }
        return len1;
    }
    public string GcdOfStrings(string str1, string str2) {
        int len1 = str1.Length;
        int len2 = str2.Length;
        int gcdLength = GreatestCommonDivisor(len1, len2);
        string candidate = str1[0..gcdLength];

        if(string.Concat(Enumerable.Repeat(candidate, len1 / gcdLength)) == str1 &&
           string.Concat(Enumerable.Repeat(candidate, len2 / gcdLength)) == str2){
            return candidate;
        } else{
            return "";
        }
    }
}
