public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] days = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; i++)
        {
            for(int j = i+1; j < temperatures.Length; j++)
            {
                if(temperatures[j] > temperatures[i])
                {
                    days[i] = j-i;
                    break;
                }
                else
                {
                    days[i] = 0;
                }
            }
        }
        return days;
    }
}
