public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> sets = new HashSet<char>();
        int length = 0;
        int l = 0;


        for(int r = 0; r < s.Length; r++)
        {
            while(sets.Contains(s[r]))
            {
                sets.Remove(s[l]);
                l++;
            }
            sets.Add(s[r]);
            length = Math.Max(length, (r-l)+1);
        }
        return length;
    }
}
