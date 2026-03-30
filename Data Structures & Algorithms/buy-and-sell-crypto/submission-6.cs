public class Solution {
    public int MaxProfit(int[] prices)
    {
        int maxReturn = int.MinValue;
        int l = 0;

        for(int r = 0; r < prices.Length; r++)
        {
            maxReturn = Math.Max(maxReturn, prices[r] - prices[l]);
            while(prices[r] < prices[l])
            {
                l++;
            }
        }
        return maxReturn;
    }
}
