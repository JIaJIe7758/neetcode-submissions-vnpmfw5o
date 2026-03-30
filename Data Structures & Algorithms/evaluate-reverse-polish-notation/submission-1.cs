public class Solution {
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();
       foreach(string s in tokens)
       {
        if(int.TryParse(s, out int number))
        {
            stack.Push(number);
        }
        else if(s.Equals("+"))
        {
            stack.Push(stack.Pop() + stack.Pop());
        }
        else if(s.Equals("-"))
        {
            int last = stack.Pop();
            int first = stack.Pop();
            stack.Push(first - last);
        }
        else if(s.Equals("*"))
        {
            stack.Push(stack.Pop() * stack.Pop());
        }
        else
        {
            int last = stack.Pop();
            int first = stack.Pop();
            stack.Push(first / last);
        }
       }
       return stack.Pop();
    }
}
