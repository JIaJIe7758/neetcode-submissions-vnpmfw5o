public class Solution {
    public int MaxArea(int[] heights) {
        
        int l = 0;
        int r = heights.Length-1;
        int area = 0;
        while(l < r) {
            
            if(heights[l] < heights[r]) {
                area = Math.Max(area, (r-l) * heights[l]);
                l++;
            } else {
                area = Math.Max(area, (r-l) * heights[r]);
                r--;
            }
        }
        return area;
    }
}
