public class Solution {
    public bool IsPalindrome(string s) {
       
       StringBuilder builder = new StringBuilder();

       foreach(char c in s) {
            if(Char.IsLetter(c) || Char.IsNumber(c)) {
                builder.Append(Char.ToLower(c));
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
