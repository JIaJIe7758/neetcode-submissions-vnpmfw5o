public class Solution {
    public int FindMin(int[] nums)
    {
        int l = 0;
        int r = nums.Length-1;
        int res = nums[0];

        while(l <= r)
        {
            if(nums[l] < nums[r])
            {
                res = Math.Min(nums[l],res);
                break;
            }
            int mid = (l+r) / 2;
            if(nums[mid] >= nums[r])
            {
                l = mid + 1;
                res = Math.Min(nums[mid],res);
            }
            else
            {
                r = mid - 1;
                res = Math.Min(nums[mid],res);
            }
        }
        return res;
    }
}
