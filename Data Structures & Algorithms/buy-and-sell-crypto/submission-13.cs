public class Solution {
    public int MaxProfit(int[] prices) {
        
        int l = 0;
        int res = 0;

        for(int r = 1; r < prices.Length; r++) {

            int profit = prices[r] - prices[l];

            if(profit <= 0) {
                profit = 0;
                l = r;
            } else {
                res = Math.Max(res, profit);
            }
        }

        return res;
    }
}
