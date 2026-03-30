public class Solution {
    public int EvalRPN(string[] tokens) {
        
       Stack<int> stack = new Stack<int>();

       foreach(string s in tokens) {
            if(int.TryParse(s, out int num)) {
                stack.Push(num);
            } else if(s.Equals("+")) {
                stack.Push(stack.Pop() + stack.Pop());
            } else if(s.Equals("*")) {
                stack.Push(stack.Pop() * stack.Pop());
            } else if(s.Equals("-")) {
                int second = stack.Pop();
                int first = stack.Pop();
                stack.Push(first - second);
            } else if(s.Equals("/")) {
                int second = stack.Pop();
                int first = stack.Pop();
                stack.Push(first / second);
            }
       }
       return stack.Pop();
    }
}
