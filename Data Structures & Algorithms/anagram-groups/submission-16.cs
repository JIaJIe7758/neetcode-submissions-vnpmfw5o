public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var dict = new Dictionary<string, List<string>>();

        foreach(string s in strs) {
            int[] count = new int[26];

            for(int i = 0; i < s.Length; i++) {
                count[s[i] - 'a']++;
            }

            string temp = String.Join(',', count);

            if(!dict.ContainsKey(temp)) {
                dict[temp] = new List<string>();
            }

            dict[temp].Add(s);
        }

        List<List<string>> res = new List<List<string>>(dict.Values);
        return res;
    }
}
