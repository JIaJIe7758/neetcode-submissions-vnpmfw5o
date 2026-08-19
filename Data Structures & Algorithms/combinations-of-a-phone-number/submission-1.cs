public class Solution {
    private List<string> res;
    private Dictionary<string, string> dict = new Dictionary<string, string>(){
        {"2", "abc"}, {"3", "def"}, {"4", "ghi"}, {"5", "jkl"}, {"6", "mno"},
        {"7", "pqrs"}, {"8", "tuv"}, {"9", "wxyz"}
    };
    public List<string> LetterCombinations(string digits) {
        res = new List<string>();
        if(String.IsNullOrEmpty(digits)) return res;
        
        string temp = "";
        Backtrack(0, temp, digits);
        return res;
    }
    public void Backtrack(int i, string temp, string digits) {

        if(temp.Length == digits.Length) {
            res.Add(temp);
            return;
        }

        foreach(char c in dict[digits[i].ToString()]) {
            Backtrack(i+1, temp + c, digits);
        } 
    }
}
