public class Solution {
    public string MergeAlternately(string word1, string word2) {

        StringBuilder builder = new StringBuilder();
       int l = 0;
       int r = 0;

       while(l < word1.Length && r < word2.Length) {
            builder.Append(word1[l++]);
            builder.Append(word2[r++]);
       }

       while(l < word1.Length) {
            builder.Append(word1[l++]);
       }

       
       while(r < word2.Length) {
            builder.Append(word2[r++]);
       }

       return builder.ToString();
    }
}