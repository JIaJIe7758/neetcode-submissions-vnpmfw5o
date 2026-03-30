public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int l = 0;
        int k = s1.Length;
        string temp = "";
        
        for(int r = 0; r < s2.Length; r++) {
            
            temp += s2[r];
            if(temp.Length > k) {
                temp = temp.Substring(1);
            }

            if(temp.Length == k) {
                if(isAnagram(temp, s1)) return true;
            }
        }

        return false;

    }
    public bool isAnagram(string s1, string s2) {
       if(s1.Length != s2.Length) return false;

       int[] count = new int[26];

       for(int i = 0; i < s1.Length; i++) {
            count[s1[i] - 'a']++;
            count[s2[i] - 'a']--;
       }

       foreach(int i in count) {
            if(i != 0) return false;
       }

       return true;
    }
}
