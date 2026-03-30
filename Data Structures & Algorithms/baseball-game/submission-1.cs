public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new Stack<int>();

        foreach(string s in operations) {
            if(int.TryParse(s, out int num)) {
                stack.Push(num);
            } else if(s.Equals("+")) {
                int second = stack.Pop();
                int first = stack.Pop();
                stack.Push(first);
                stack.Push(second);
                stack.Push(first + second);
            } else if(s.Equals("C")) {
                stack.Pop();
            } else if(s.Equals("D")) {
                stack.Push(stack.Peek() * 2);
            }
        }

        return stack.Sum();
    }
}