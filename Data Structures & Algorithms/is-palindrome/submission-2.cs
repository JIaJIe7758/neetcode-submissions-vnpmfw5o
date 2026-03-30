public class Solution {
    public bool IsPalindrome(string s) {

        string newS = "";
        foreach(char c in s)
        {
            if(Char.IsLetterOrDigit(c))
            {
                newS += c.ToString().ToLower();
            }
        }

        int l = 0;
        int r = newS.Length -1;

        while(l < r)
        {
            if(newS[l] != (newS[r]))
            {
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}
