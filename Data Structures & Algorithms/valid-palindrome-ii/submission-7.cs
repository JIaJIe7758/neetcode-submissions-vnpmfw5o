public class Solution {
    public bool ValidPalindrome(string s) {
        
        int l = 0;
        int r = s.Length-1;

        while(l < r) {
            if(s[l] != s[r]) {
                if(IsPalindrome(s.Substring(0,l) +s.Substring(l+1)) ||
                    IsPalindrome(s.Substring(0,r) + s.Substring(r+1))) {
                        return true;
                    }

                    return false;
            }
            l++;
            r--;
        }

        return true;
    }
    public bool IsPalindrome(string s) {
        
        var builder = new StringBuilder();

        foreach(char c in s) {
            if(Char.IsLetter(c) || Char.IsNumber(c)) {
                builder.Append(c);
            }
        }

        int l = 0;
        int r = builder.Length-1;

        while(l < r) {
            if(builder[l] != builder[r]) {
                return false;
            }

            l++;
            r--;
        }

        return true;
    }
}