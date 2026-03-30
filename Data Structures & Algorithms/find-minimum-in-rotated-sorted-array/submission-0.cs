public class Solution {
    public int FindMin(int[] nums)
    {
        int min = nums[0];
        foreach(int i in nums)
        {
            if(i < min) min = i;
        }
        return min;
    }
}
