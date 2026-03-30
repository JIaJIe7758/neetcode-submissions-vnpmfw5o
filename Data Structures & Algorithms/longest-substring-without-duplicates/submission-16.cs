public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        HashSet<char>set = new HashSet<char>();
        int longest = 0;
        int l = 0;

        for(int r = 0; r < s.Length; r++) { 

            
            while(set.Contains(s[r])) {//p-w-w
                set.Remove(s[l]);
                l++;
            }

            longest = Math.Max(longest, r-l+1);
            set.Add(s[r]);
        }

        return longest;
    }
}
