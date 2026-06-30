public class Solution {
    public int EvalRPN(string[] tokens) {
        
        var stack = new Stack<int>();

        foreach(string c in tokens) {
            if(int.TryParse(c, out int num)) {
                stack.Push(num);
            } else if(c.Equals("+")) {
                stack.Push(stack.Pop() + stack.Pop());
            } else if(c.Equals("*")) {
                stack.Push(stack.Pop() * stack.Pop());
            } else if(c.Equals("/")) {
                int num2 = stack.Pop();
                int num1 = stack.Pop();
                stack.Push(num1 / num2);
            } else if(c.Equals("-")) {
                int num2 = stack.Pop();
                int num1 = stack.Pop();
                stack.Push(num1 - num2);
            }
        }
        return stack.Peek();
    }
}
