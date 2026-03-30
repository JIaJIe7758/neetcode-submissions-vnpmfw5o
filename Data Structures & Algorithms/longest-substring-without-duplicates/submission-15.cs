public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l = 0;
        var set = new HashSet<char>();
        int length = int.MinValue;

        for(int r = 0; r < s.Length; r++) {
            
            while(set.Contains(s[r])) {
                set.Remove(s[l]);
                l++;
            }
            set.Add(s[r]);

            length = Math.Max(length, (r-l+1));
        }
        return s.Length < 1? 0: length;
    }
}
