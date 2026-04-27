public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        
        int l = 0;
        StringBuilder temp = new StringBuilder();

        for(int r = 0; r < s2.Length; r++) {

            temp.Append(s2[r]);

            if(r-l+1 == s1.Length) {
                if(IsAnagram(temp.ToString(), s1)) {
                    return true;
                } else {
                    temp.Remove(0,1);
                    l++;
                }
            }
        }
        return false;

    }

    public bool IsAnagram(string s1, string s2) {

        var count = new int[26];

        if(s1.Length != s2.Length) return false;

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
