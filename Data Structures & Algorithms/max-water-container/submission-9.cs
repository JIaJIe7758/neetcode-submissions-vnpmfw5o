public class Solution {
    public int MaxArea(int[] heights) {
        
        int l = 0;
        int r = heights.Length-1;

        int res = 0;

        while(l < r) {
           
            if(heights[l] < heights[r] ) {
                res = Math.Max(res, (r-l) * heights[l]);
                l++;
            } else if(heights[r] <= heights[l]) {
                res = Math.Max(res, (r-l) * heights[r]);
                r--;
            }

        }
        return res;
       
    }
}
