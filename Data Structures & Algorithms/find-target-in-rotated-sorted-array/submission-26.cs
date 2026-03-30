public class Solution {
    public int Search(int[] nums, int target)
    {
       int l = 0;
       int r = nums.Length-1;

        while(l < r) {
            int mid = (l+r) / 2;
            if(nums[mid] > nums[r]) {
                l = mid+1;
            } else {
                r = mid;
            }
        }

        //[1,2,3,4]  [4,1,2,3] [3,4,1,2] target = 4
        int start = l;
        l = 0;
        r = nums.Length-1;
        if(target >= nums[start] && target <= nums[r]) {
            l = start;
        } else {
            r = start;
        }

        while(l <= r) {
            int mid = (l+r) / 2;
            if(nums[mid] < target) {
                l = mid +1;
            } else if(nums[mid] > target) {
                r = mid -1;
            } else {
                return mid;
            }
        }
        return -1;


    }
}

