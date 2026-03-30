public class Solution {
    public int MaxProfit(int[] prices) {
        
        int l = 0;
        int profit = 0;

        for(int r = 0; r < prices.Length; r++) {

            if(prices[r] < prices[l]) {
                l = r;
            }

            if(prices[r] > prices[l]) {
                profit = Math.Max(profit, prices[r] - prices[l]);
            }
        }

        return profit;
    }
}
