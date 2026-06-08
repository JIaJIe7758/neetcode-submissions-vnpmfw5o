public class Solution {
    public bool IsValid(string s) {
        
        var stack = new Stack<char>();
        var dict = new Dictionary<char,char>() {
            {']', '['},
            {')', '('},
            {'}', '{'}
        };

        foreach(char c in s) {
            if(stack.Count >= 1 && dict.ContainsKey(c)) {
                if(dict[c] == stack.Peek()) {
                    stack.Pop();
                } else {
                    return false;
                }
            } else {
                stack.Push(c);
            }
        }

        return stack.Count == 0;

    }
}
