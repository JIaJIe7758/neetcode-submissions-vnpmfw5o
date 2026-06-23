public class Solution {
    public int MaxProfit(int[] prices) {
        
        int l = 0;
        int maxProfit = 0;

        for(int r = 0; r < prices.Length; r++) {

            int profit = prices[r] - prices[l];

            if(profit <= 0) {
                l = r;
            }

            maxProfit = Math.Max(maxProfit, profit);
        }

        return maxProfit;
    }
}
