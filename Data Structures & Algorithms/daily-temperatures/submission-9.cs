public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
       int[] res = new int[temperatures.Length];

       Stack<int[]> stack = new Stack<int[]>();

       for(int i = 0; i < temperatures.Length; i++) {

            while(stack.Count > 0 && (temperatures[i] > stack.Peek()[0])) {
                int[] temp = stack.Pop();
                res[temp[1]] = i - temp[1];

            }

            stack.Push(new int[]{temperatures[i],i});
       }
       return res;
    }
}
