public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        var res = new int[temperatures.Length];
        var stack = new Stack<int[]>();

        for(int i = 0; i< temperatures.Length; i++) {
            
            while(stack.Count > 0 && stack.Peek()[1] < temperatures[i]) {
                int[] pair = stack.Pop();
                res[pair[0]] = i - pair[0];
            }

            stack.Push(new int[]{i, temperatures[i]});
        }
        return res;
    }
}
