public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] res = new int[temperatures.Length]; 
        Stack<int[]> stack = new Stack<int[]>();

        for(int i = 0; i < temperatures.Length; i++)
        {
            while(stack.Count > 0 && stack.Peek()[1] < temperatures[i])
            {
                res[stack.Peek()[0]] = i - stack.Peek()[0];
                stack.Pop();
            }
            stack.Push(new int[]{i, temperatures[i]});
        }
        return res;
    }
    
}
