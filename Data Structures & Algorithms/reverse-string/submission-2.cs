public class Solution {
    public void ReverseString(char[] s) {
       
       int l = 0;
       int r = s.Length-1;

       while(l < r) {
            char temp = s[r];
            s[r] = s[l];
            s[l] = temp;

            l++;
            r--;
       }
    }
}