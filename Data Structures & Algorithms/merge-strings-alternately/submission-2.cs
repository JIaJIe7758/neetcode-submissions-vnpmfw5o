public class Solution {
    public string MergeAlternately(string word1, string word2)
    {
        var sb = new StringBuilder();

        int w1 = 0;
        int w2 = 0;

        while(w1 < word1.Length && w2 < word2.Length) {
            sb.Append(word1[w1++]);
            sb.Append(word2[w2++]);
        }

        while(w1 < word1.Length) {
            sb.Append(word1[w1++]);
        }

        while(w2 < word2.Length) {
            sb.Append(word2[w2++]);
        }

        return sb.ToString();
    }
}