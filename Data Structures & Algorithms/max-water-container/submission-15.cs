public class Solution {
    public int MaxArea(int[] heights) {
        
        int l = 0;
        int r = heights.Length-1;
        int area = 0;

        while(l < r) {

            int lower = Math.Min(heights[l], heights[r]);
            area = Math.Max(area, (lower * (r-l)));

            if(heights[l] == lower) {
                l++;
            } else if(heights[r] == lower) {
                r--;
            }
        }

        return area;
    }
}
