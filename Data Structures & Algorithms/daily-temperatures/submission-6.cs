public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] res = new int[temperatures.Length];
        Stack<int[]> pair = new Stack<int[]>();

        for(int i = 0; i< temperatures.Length; i++) {
            while(pair.Count > 0 && temperatures[i] > pair.Peek()[1]) {
                var prev = pair.Pop();
                res[prev[0]] = i - prev[0];
            }
            pair.Push(new int[]{i,temperatures[i]});
        }
        return res;
    }
    
}
