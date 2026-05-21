public class Solution {
    public int EvalRPN(string[] tokens) {
        
        var stack = new Stack<int>();

        foreach(string s in tokens) {
            if(int.TryParse(s, out int num)) {
                stack.Push(num);
            } else if(s.Equals("+")) {
                stack.Push(stack.Pop() + stack.Pop());
            } else if(s.Equals("*")) {
                stack.Push(stack.Pop() * stack.Pop());
            } else if(s.Equals("-")) {
                int n2 = stack.Pop();
                int n1 = stack.Pop();
                stack.Push(n1 - n2);
            } else if(s.Equals("/")) {
                int n2 = stack.Pop();
                int n1 = stack.Pop();
                stack.Push(n1 / n2);
            }
        }

        return stack.Peek();
    }
}
