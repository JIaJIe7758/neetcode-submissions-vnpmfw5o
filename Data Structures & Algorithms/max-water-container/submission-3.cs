public class Solution {
    public int MaxArea(int[] heights)
    {
        int area = 0;
        int l = 0;
        int r = heights.Length-1;

        while(l < r)
        {
            if(heights[r] <= heights[l])
            {
                area = Math.Max((r-l) * heights[r], area);
                r--;
            }
            else
            {
                area = Math.Max((r-l) * heights[l], area);
                l++;
            }
        }
        return area;
    }
}
