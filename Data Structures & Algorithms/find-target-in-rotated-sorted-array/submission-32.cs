public class Solution {
    public int Search(int[] nums, int target) {
        
        int l = 0;
        int r = nums.Length-1;

        while(l < r) {
            int mid = l + (r-l) / 2;

            if(nums[mid] < nums[r]) {
                r = mid;
            } else if(nums[mid] > nums[r]) {
                l = mid+1;
            }
        }


        int min = l;
        l = 0;
        r = nums.Length-1;

        if(target >= nums[min] && target <= nums[r]) {
            l = min;
        } else {
            r = min-1;
        }

        while(l <= r) {
            int mid = l + (r-l) / 2;

            if(nums[mid] == target) {
                return mid;
            } else if(nums[mid] < target) {
                l = mid+1;
            } else {
                r = mid-1;
            }
        }

        return -1;
    }
}
