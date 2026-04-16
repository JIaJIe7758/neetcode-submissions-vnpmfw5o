public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        var res = new int[temperatures.Length];
        var stack = new Stack<int>();

        for(int i = 0; i < temperatures.Length; i++) { //38

            while(stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]) {
                int index = stack.Pop();
                res[index] = i - index;

            }

            stack.Push(i);
        }

        return res;
    }
}
