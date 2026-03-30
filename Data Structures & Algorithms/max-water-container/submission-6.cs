public class Solution {
    public int MaxArea(int[] heights) {
        
        int l = 0;
        int r = heights.Length-1;
        int area = 0;
        while(l < r) {
            //int min = heights[r] <= heights[l]? heights[r]: heights[l];

            if(heights[r] <= heights[l]) {
                area = Math.Max(area, (r-l) * heights[r]);
                r--;
            } else {
                area = Math.Max(area, (r-l) * heights[l]);
                l++;
            }
        }
        return area;
    }
}
