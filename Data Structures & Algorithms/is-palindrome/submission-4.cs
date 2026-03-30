public class Solution {
    public bool IsPalindrome(string s)
    {
        StringBuilder st = new StringBuilder();
        foreach(char c in s)
        {
            if(Char.IsLetterOrDigit(c))
            {
                st.Append(Char.ToLower(c));
            }
        }

        int l = 0;
        int r = st.Length-1;

        while(l < r)
        {
            if(!st[l].Equals(st[r]))
            {
                return false;
            }
            l++;
            r--;
        }
        return true;


    }
}
