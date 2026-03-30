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
        // we found the index of minimum value and put in "start" to use as pivot
        
        int start = left;
        left = 0;
        right = nums.Length-1;

        if(target >= nums[start] && target <= nums[right]) left = start;
        else right = start;

        while(left <= right)
        {
            int midPoint = (left + right) / 2;
            if(nums[midPoint] == target) return midPoint;
            else if(nums[midPoint] > target) right = midPoint -1;
            else if(nums[midPoint] < target) left = midPoint +1;
        }

        return -1;
    }
}

