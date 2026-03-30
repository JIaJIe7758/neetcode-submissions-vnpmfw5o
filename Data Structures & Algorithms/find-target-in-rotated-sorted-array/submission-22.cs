public class Solution {
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length-1;

        while(left < right)
        {
            int mid = (left + right) / 2;
            if(nums[mid] > nums[right])
            {
                left = mid+1;
            }
            else
            {
                right = mid;
            }
        }

        int start = left;
        left = 0;
        right = nums.Length-1;

        if(target >= nums[start] && nums[right] >= target)
        {
            left = start;
        }
        else
        {
            right = start;
        }

        while(left <= right)
        {
            int mid = (left + right) / 2;

            if(nums[mid] < target)
            {
                left = mid+1;
            }
            else if(nums[mid] > target)
            {
                right = mid-1;
            }
            else
            {
                return mid;
            }
        }
        return -1;
    }
}

