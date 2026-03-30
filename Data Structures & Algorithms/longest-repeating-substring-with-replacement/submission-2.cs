public class Solution {
    public int CharacterReplacement(string s, int k)
    {
       int[] count = new int[26];
       int maxFrequency = 0;
       int l = 0; 
       int length = int.MinValue;

       for(int r = 0; r < s.Length; r++) {
            count[s[r] - 'A']++;
            int countMax = count[s[r] - 'A'];
            maxFrequency = Math.Max(maxFrequency, countMax);
            while((maxFrequency + k) < (r-l + 1)) {
                count[s[l] - 'A']--;
                l++;
            }
            length = Math.Max(length, (r-l+1));
       }
       return length;
    }
}
