public class Solution {
    public bool IsValid(string s)
    {
        var dict = new Dictionary<char,char>()
        {
            {']','['},
            {')','('},
            {'}','{'}
        };

        var stack = new Stack<char>();

        foreach(char c in s) {
            if(stack.Count > 0 && dict.ContainsKey(c)) {
                if(stack.Peek() == dict[c]) {
                    stack.Pop();
                } else {
                    stack.Push(c);
                }
            } else {
                stack.Push(c);
            }
            
        }
        return stack.Count == 0;
    }   
}
