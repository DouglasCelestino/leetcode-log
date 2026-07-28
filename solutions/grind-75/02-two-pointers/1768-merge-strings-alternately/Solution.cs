using System.Text;

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int len1 = word1.Length; int len2 = word2.Length;
        var result = new StringBuilder(len1 + len2);
        int j = Math.Min(len1, len2);
        for (int i = 0; i < j; i++){
            result.Append(word1[i]).Append(word2[i]);
        }
        if(j == len1){
            return result.Append(word2[j..len2]).ToString();
        } else {
            return result.Append(word1[j..len1]).ToString();
        }
    }
}
