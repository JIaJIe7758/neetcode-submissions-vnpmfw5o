public class Solution {
    public string MergeAlternately(string word1, string word2) {
        
        int w1 = 0, w2 = 0;
        var builder = new StringBuilder();

        while(w1 < word1.Length && w2 < word2.Length) {
            builder.Append(word1[w1++]);
            builder.Append(word2[w2++]);
        }

        while(w1 < word1.Length) {
          builder.Append(word1[w1++]);
        }

        
        while(w2 < word2.Length) {
          builder.Append(word2[w2++]);
        }

        return builder.ToString();
    }
}