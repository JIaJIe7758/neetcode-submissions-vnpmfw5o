public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        var stack = new Stack<int>();//only index
        var res = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; i++) {

            while(stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]) {
                int temp = stack.Pop();
                res[temp] = i - temp;
            }

            stack.Push(i);
        }

        return res;
    }
}
