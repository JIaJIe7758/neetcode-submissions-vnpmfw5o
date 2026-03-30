public class Solution {
    public int MaxArea(int[] heights)
    {
        int l = 0;
        int r = heights.Length-1;
        int area = 0;

        while(l < r)
        {
            int min = Math.Min(heights[l],heights[r]);
            area = Math.Max(area, (r-l) * min);
            
            if(heights[l] == min)
            {
                l++;
            }
            else
            {
                r--;
            }
        }
        return area;  
    }
}
