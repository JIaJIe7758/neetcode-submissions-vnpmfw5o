public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
    {
       var dict = new Dictionary<string,List<string>>();
       
       foreach(string s in strs) {
        int[] sCount = new int[26];
        for(int i = 0; i < s.Length; i++) {
            sCount[s[i] - 'a']++;
        }
        
        string key = String.Join(",", sCount);
        if(!dict.ContainsKey(key)) {
            dict[key] = new List<string>();
        }
        dict[key].Add(s);
       }

       return dict.Values.ToList<List<string>>();
    }
    
}
