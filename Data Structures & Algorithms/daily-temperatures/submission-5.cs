public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] res = new int[temperatures.Length];
        Stack<int[]> pair = new Stack<int[]>();

        for(int i = 0; i< temperatures.Length; i++) {
            while(pair.Count > 0 && temperatures[i] > pair.Peek()[1]) {
                int index = pair.Peek()[0];
                int days = i - index;
                res[index] = days;
                pair.Pop();
            }
            pair.Push(new int[]{i,temperatures[i]});
        }
        return res;
    }
    
}
