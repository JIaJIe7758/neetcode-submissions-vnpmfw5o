public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dict = new Dictionary<string,List<string>>();

        foreach(string s in strs)
        {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string newS = new String(chars);
            if(!dict.ContainsKey(newS))
            {
                dict[newS] = new List<string>();
            }
            dict[newS].Add(s);
        }
        return new List<List<string>>(dict.Values);
    }
}
