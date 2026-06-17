public class Solution {
    public int MaxArea(int[] heights) {
        
        int l = 0;
        int r = heights.Length-1;
        int maxArea = 0;

        while(l < r) {
            int lower = Math.Min(heights[l], heights[r]);
            int area = (r-l) * lower;

            if(lower == heights[l]) {
                maxArea = Math.Max(maxArea, area);
                l++;
            } else if(lower == heights[r]) {
                maxArea = Math.Max(maxArea, area);
                r--;
            }
        }

        return maxArea;
    }
}
