public class Solution {
    public int LengthOfLongestSubstring(string s) {

        var set = new HashSet<char>();

        int l = 0;
        int longest = 0;

        for(int r = 0; r < s.Length; r++) {
            
            while(set.Contains(s[r])) {
                set.Remove(s[l]);
                l++;
            }

            longest = Math.Max(longest, r-l+1);
            set.Add(s[r]);
        }

        return longest;
    }
}
