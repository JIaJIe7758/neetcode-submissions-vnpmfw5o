public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        int length = 1;
        int l = 0;
        HashSet<char> set = new HashSet<char>();

        if(s.Length == 0) return 0;

        for(int r = 0; r < s.Length; r++)
        {
            while(set.Add(s[r]) == false)
            {
                set.Remove(s[l]);
                l++;
            }
            length = Math.Max(length, set.Count);
        }
        if(length == 1) return set.Count;
        return length;


    }
}
