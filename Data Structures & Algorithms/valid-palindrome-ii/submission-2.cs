public class Solution {
    public bool ValidPalindrome(string s)
    {
       int l = 0;
       int r = s.Length-1;

       while(l < r) {
            if(s[l] != s[r]) {
                string s1 = s.Substring(0, l) + s.Substring(l+1);
                string s2 = s.Substring(0,r) + s.Substring(r+1);
                if(isPalindrome(s1) || isPalindrome(s2)) {
                    return true;
                } else {
                    return false;
                }
            }
            l++;
            r--;
       }
       return true;
    }
    public bool isPalindrome(string s)
    {
        if(s.Length <= 0) {
            return false;
        }
        int l = 0;
        int r = s.Length-1;

        while(l < r) {
            if(s[r] != s[l]) {
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}