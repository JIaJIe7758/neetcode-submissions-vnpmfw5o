public class Solution {
    public int MaxProfit(int[] prices) {
        
        int profit = 0;

        for(int r = 1; r < prices.Length; r++) {
            if(prices[r] > prices[r-1]) {
                profit += prices[r] - prices[r-1];
            }
        }

        return profit;
    }
}