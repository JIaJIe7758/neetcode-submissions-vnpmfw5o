public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        char[] sSort = s.ToCharArray();
        char[] tSort = t.ToCharArray();
        Array.Sort(sSort);
        Array.Sort(tSort);

        for(int i = 0; i< sSort.Length; i++)
        {
            if(!sSort[i].Equals(tSort[i]))
            {
                return false;
            }
        }
        return true;
    }
}
