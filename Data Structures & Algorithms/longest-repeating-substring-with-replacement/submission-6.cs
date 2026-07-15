public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        int l = 0;
        int longest = 0;
        var count = new int[26];

        for(int r = 0; r < s.Length; r++) {
            count[s[r] - 'A']++;

            int countMax = count.Max();

            if(countMax + k < r-l+1) {
                count[s[l] - 'A']--;
                l++;
            }

            longest = Math.Max(longest, r-l+1);
        }

        return longest;
    }
}
