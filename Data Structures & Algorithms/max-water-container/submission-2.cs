public class Solution {
    public int MaxArea(int[] heights)
    {
        int l = 0;
        int r = heights.Length-1;
        int area = 0;
       while(l < r)
       {
            int min = Math.Min(heights[l],heights[r]);
            int temp = (r - l) * min;
            area = Math.Max(area, temp);
            if(heights[l]>= heights[r])
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
