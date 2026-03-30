public class Solution {
    public int MaxArea(int[] heights)
    {
        int l = 0;
        int r = heights.Length-1;

        int area = 0;

        while(l < r) { 
            
            int height = heights[l] < heights[r]? heights[l]: heights[r];
            area = Math.Max(area, (r-l) * height);
            if(heights[r] <= heights[l]) {
                r--;
            } else {
                l++;
            }

        }
        return area;
    }
}
