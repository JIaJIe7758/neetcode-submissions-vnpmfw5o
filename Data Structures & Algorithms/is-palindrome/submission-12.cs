public class Solution {
    public bool IsPalindrome(string s) {
        
        StringBuilder word = new StringBuilder();

        foreach(char c in s) {
            if(Char.IsLetter(c) || Char.IsNumber(c)) {
                word.Append(Char.ToLower(c));
            }
        }
        Console.WriteLine(word);

        int l = 0;
        int r = word.Length-1;

        while(l < r) {
            if(word[l] != word[r]) return false;

            l++;
            r--;
        }

        return true;
    }
}
