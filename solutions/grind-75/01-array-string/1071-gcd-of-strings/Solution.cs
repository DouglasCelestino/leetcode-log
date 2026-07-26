public class Solution {
    public int GreatestDivisorCommon(int len1, int len2){
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
        int len_mdc = GreatestDivisorCommon(len1, len2);
        string x = str1[0..len_mdc];

        if(string.Concat(Enumerable.Repeat(x, len1 / len_mdc)) == str1 &&
           string.Concat(Enumerable.Repeat(x, len2 / len_mdc)) == str2){
            return x;
        } else{
            return "";
        }
    }
}
