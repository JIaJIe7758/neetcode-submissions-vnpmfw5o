public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
        for(int i = 0; i < strs[0].Length; i++)
        {
            char c = strs[0][i];

            for(int j = 0; j < strs.Length; j++)
            {
                if(i >= strs[j].Length || c != strs[j][i])
                {
                    return strs[0].Substring(0,i);
                }
            }
        }
        return strs[0];
    }
}