public class Solution {
    public int CharacterReplacement(string s, int k) {

        int[] count = new int[26];
        int length = 0;
        int l = 0;

        for(int r = 0; r < s.Length; r++) {
            count[s[r] - 'A']++;
            int countMax = count.Max();

            while((countMax + k) < (r-l+1)) {
                count[s[l] - 'A']--;
                l++;
            }

            length = Math.Max(length, r-l+1); 
        }
        return length;
    }

    // countMax + k <  r-l+1
}
