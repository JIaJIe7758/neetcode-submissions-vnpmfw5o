public class Solution {
    public int CharacterReplacement(string s, int k)
    {
        int maxFrequency = 0;
        int length = 0;
        int l = 0;
        int[] charCount = new int[26];

        for(int r = 0; r < s.Length; r++)
        {
            charCount[s[r]- 'A']++;
            int count = charCount[s[r]- 'A'];
            maxFrequency = Math.Max(maxFrequency, count);

            while ((r - l + 1) - maxFrequency > k)
            {
                charCount[s[l] - 'A']--;
                l++;
            }

            length = Math.Max(length,(r-l)+1 );
            
        }
         return length;

    }
}
