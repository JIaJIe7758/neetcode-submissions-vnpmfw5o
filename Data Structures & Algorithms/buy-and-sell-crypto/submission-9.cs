public class Solution {
    public int MaxProfit(int[] prices)
    {
       int profit = 0;
       int l = 0;

       for(int r = 1; r < prices.Length; r++) {
            int v = prices[r] - prices[l];
            profit = Math.Max(profit, v);

            while(prices[r] - prices[l] < 0) {
                l = r;
            }
       }
       return profit;
    }
}
