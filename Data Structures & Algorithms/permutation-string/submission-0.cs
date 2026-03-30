public class Solution {
    public bool CheckInclusion(string s1, string s2)
    {
        // sliding window with fixed length of s1
        // we can form a window in every length of s1
        // than we check if the window is anagram of s1

        int l = 0;
        int k = s1.Length;

        for(int r = 0; r < s2.Length; r++)
        {
            if((r-l) + 1 == k)
            {
                string temp = s2.Substring(l, k);
                if(isAnagram(s1,temp))
                {
                    return true;
                }
                l++;
            }
        }
        return false;
    }
    public bool isAnagram(string s1, string s2)
    {
        char[] charS1 = s1.ToCharArray();
        char[] charS2 = s2.ToCharArray();
        Array.Sort(charS1);
        Array.Sort(charS2);

        for(int i = 0; i < charS1.Length; i++)
        {
            if(charS1[i] != charS2[i])
                return false;
        }
        return true;
    }
}
