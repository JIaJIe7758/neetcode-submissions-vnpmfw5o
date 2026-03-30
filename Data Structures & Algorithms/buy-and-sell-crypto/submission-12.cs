public class Solution {
    public int MaxProfit(int[] prices) {
        
       int l = 0;
       int res = 0;
       
       for(int r = 1; r < prices.Length; r++) {

            int profit = 0;

            if(prices[r] <= prices[l]) {
                l = r;
            } else {
                profit = prices[r] - prices[l];
            }

            res = Math.Max(res, profit);

       }

       return res;

    }
}
