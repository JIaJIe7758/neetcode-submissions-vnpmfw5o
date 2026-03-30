public class Solution {
    public int MaxArea(int[] heights)
    {
        int l = 0;
        int r = heights.Length-1;
        int area = 0;
        while(l<r)
        {
            area  = Math.Max((r-l) * Math.Min(heights[r],heights[l]),area);
            if(Math.Min(heights[r],heights[l]) == heights[r])
            {
                r--;
            }
            else
            {
                l++;
            }
        }
        return area;
    }
}
