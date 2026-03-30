public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] days = new int[temperatures.Length]; 
        Stack<int[]> stack = new Stack<int[]>(); // we save temperature/index pair

        for(int i = 0; i < temperatures.Length; i++)
        {
            int t = temperatures[i];
            while(stack.Count > 0 && t > stack.Peek()[0])
            {
                int d = i - stack.Peek()[1];
                days[stack.Peek()[1]] = d;
                stack.Pop();
            }
            stack.Push(new int[]{t,i});
        }
        return days;
    }
}
