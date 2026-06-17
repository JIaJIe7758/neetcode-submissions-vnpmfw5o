public class Solution {
    public int MaxArea(int[] heights) {
        
        int l = 0;
        int r = heights.Length-1;
        int maxArea = 0;

        while(l < r) {
            int lower = Math.Min(heights[l], heights[r]);
            int area = (r-l) * lower;
            maxArea = Math.Max(maxArea, area);

            if(lower == heights[l]) {
                l++;
            } else if(lower == heights[r]) {
                r--;
            }
        }

        return maxArea;
    }
}
