public class Solution {
    public int CalPoints(string[] operations) {
       var stack = new Stack<int>();

       foreach(string s in operations) {
            
            if(int.TryParse(s, out int num)) {
                stack.Push(num);
            } else if(s == "+") {
                int second = stack.Pop();
                int first = stack.Pop();
                stack.Push(first);
                stack.Push(second);
                stack.Push(first + second);
            } else if(s == "D") { 
                stack.Push(stack.Peek() * 2);
            } else if(s == "C") {
                stack.Pop();
            }
       }

       return stack.Sum();
    }
}