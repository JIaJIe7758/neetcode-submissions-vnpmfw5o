public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var res = new StringBuilder();
        int w1 = 0;
        int w2 = 0;

        while(w1 < word1.Length && w2 < word2.Length)
        {
            res.Append(word1[w1++]);
            res.Append(word2[w2++]);
        }

        while(w1 < word1.Length)
        {
            res.Append(word1[w1++]);
        }

        
        while(w2 < word2.Length)
        {
            res.Append(word2[w2++]);
        }

        return res.ToString();
    }
}