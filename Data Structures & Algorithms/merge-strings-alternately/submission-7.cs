public class Solution {
    public string MergeAlternately(string word1, string word2) {
        
        int l = 0;
        int r = 0;
        var res = new StringBuilder();

        while(l < word1.Length && r < word2.Length) {
          res.Append(word1[l++]);
          res.Append(word2[r++]);
        }

        while(l < word1.Length) {
          res.Append(word1[l++]);
        }

        while(r < word2.Length) {
          res.Append(word2[r++]);
        }

        return res.ToString();
    }
}