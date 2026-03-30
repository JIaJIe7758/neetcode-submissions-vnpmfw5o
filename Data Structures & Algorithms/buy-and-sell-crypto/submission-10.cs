public class Solution {
    public int MaxProfit(int[] prices)
    {
        int l = 0;
        int profit = 0;
        
        for(int r = 1; r < prices.Length; r++) {
            if( prices[r] <= prices[l]) {
                l = r;
            }
            int temp = prices[r] - prices[l];
            profit = Math.Max(profit, temp);
        }
        return profit;
    }
}
