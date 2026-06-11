public class Solution {
    public int LengthOfLongestSubstring(string s) {

        var set = new HashSet<char>();

        int longest = 0;
        int l = 0;

        for(int r = 0; r < s.Length; r++) {

            while(set.Contains(s[r])) {
                set.Remove(s[l]);
                l++;
            }

            set.Add(s[r]);
            longest = Math.Max(longest, r-l+1);
        }

        return longest;
    }
}
