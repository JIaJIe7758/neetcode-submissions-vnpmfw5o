public class Solution {
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder st = new StringBuilder();
        int w1 = 0;
        int w2 = 0;
        
        while(w1 < word1.Length && w2 < word2.Length)
        {
            st.Append(word1[w1]);
            st.Append(word2[w2]);
            w1++;
            w2++;
        }

        while(w1 < word1.Length)
        {
            st.Append(word1[w1]);
            w1++;
        }

        while(w2 < word2.Length)
        {
            st.Append(word2[w2]);
            w2++;
        }

        return st.ToString();

    }
}