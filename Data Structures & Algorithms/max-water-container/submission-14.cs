public class Solution {
    public int MaxArea(int[] heights) {
        
        int l = 0;
        int r = heights.Length-1;
        int res = 0;

        while(l < r) {

            int lower = Math.Min(heights[l], heights[r]);
            int area = lower * (r-l);
            res = Math.Max(res, area);

            if(heights[l] == lower) {
                l++;
            } else if(heights[r] == lower) {
                r--;
            }
        }

        return res;
    }
}
