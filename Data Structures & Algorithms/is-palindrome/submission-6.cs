public class Solution {
    public bool IsPalindrome(string s) {
        
        int l = 0;
        string filtredS = "";

        foreach(char c in s) {
            if(Char.IsLetter(c)) {
                filtredS += Char.ToLower(c);
            } else if(Char.IsNumber(c)){
                filtredS += c;
            }
        }


        int r = filtredS.Length-1;

        while(l < r) {
            if(filtredS[l] != filtredS[r]) {
                return false;
            }
            l++;
            r--;
        }

        return true;

    }
}
