public class Solution {
    public bool IsPalindrome(string s) {
        
        string filter = "";

        foreach(char c in s)
        {
            if(Char.IsNumber(c) || Char.IsLetter(c))
            {
                filter += Char.ToLower(c);
            }
        }

        int l = 0;
        int r = filter.Length-1;

        while(l < r)
        {
            if(filter[l] != filter[r])
            {
                return false;
            }

            l++;
            r--;
        }

        return true;
    }
}
