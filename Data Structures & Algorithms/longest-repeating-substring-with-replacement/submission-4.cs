public class Solution {
    public int CharacterReplacement(string s, int k) {

        int[] count = new int[26];
        int l = 0;
        int longest = 0;

        for(int r = 0; r < s.Length; r++) {
            
            count[s[r] - 'A']++;
            int countMax = 0;
            foreach(int i in count) {
                if(i > countMax) countMax = i;
            }

            if(countMax + k < r-l+1) {
                count[s[l] - 'A']--;
                l++;
            }

            longest = Math.Max(longest, r-l+1); 
        }
        return longest;
        
    }

    // countMax + k <  r-l+1
}
