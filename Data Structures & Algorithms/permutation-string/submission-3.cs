public class Solution {
    public bool CheckInclusion(string s1, string s2)
    {
        var chars = new List<char>();
       int l = 0;

       for(int r = 0; r < s2.Length; r++) {

            chars.Add(s2[r]);

            while((r-l+1) == s1.Length) {
                string temp = new String(chars.ToArray());

                if(isAnagram(s1, temp)) {
                    return true;
                }
                chars.RemoveAt(0);
                l++;
            }
       }
       return false;
    }

    public bool isAnagram(string s1, string s2) {

        int[] count = new int[26];
        if(s1.Length != s2.Length) {
            return false;
        }

        for(int i = 0; i < s1.Length; i++) {
            
            count[s1[i] - 'a']++;
            count[s2[i] - 'a']--;
        }

        foreach(int i in count) {
            if(i != 0) {
                return false;
            }
        }
        return true;

    }
  
}
