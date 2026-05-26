public class Solution {
    public int MaxProfit(int[] prices) {
        
        int l = 0;
        int maxProfit = 0;

        for(int r = 1; r < prices.Length; r++) {
            int temp = prices[r] - prices[l];

            if(temp < 0) {
                l = r;
            }

            maxProfit = Math.Max(temp, maxProfit);
        }

        return maxProfit;
    }
}
