public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string,List<string>> dict = new Dictionary<string,List<string>>();

        foreach(string s in strs)
        {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string word = new String(chars);
            if(!dict.ContainsKey(word))
            {
                dict[word] = new List<string>();
            }
            dict[word].Add(s);
        }
        List<List<string>> output = new List<List<string>>(dict.Values);
        return output;
    }
}
