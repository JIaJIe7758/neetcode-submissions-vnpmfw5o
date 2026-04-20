public class Solution {
    public int MaxArea(int[] heights) {

        int l = 0;
        int r = heights.Length-1;
        int res = 0;

        while(l < r) {

            int lower = Math.Min(heights[l], heights[r]);
            int area = lower * (r-l);

            if(heights[l] <= heights[r]) {
                l++;
            } else if(heights[l] > heights[r]) {
                r--;
            }

            res = Math.Max(res, area);
        }

        return res;
       
    }
}
