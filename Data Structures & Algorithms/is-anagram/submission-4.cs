public class Solution {
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length) return false;

        int[] group = new int[26];

        for(int i = 0; i < s.Length; i++) {
            group[s[i] - 'a']++;
            group[t[i] - 'a']--;
        }

        foreach(int i in group) {
            if(i != 0) return false;
        }

        return true;
    }
}
