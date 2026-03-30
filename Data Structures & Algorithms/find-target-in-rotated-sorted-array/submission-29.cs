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

        int start = l;
        l = 0;
        r = nums.Length-1; 

        if(target <= nums[r] && target >= nums[start]) {
            l = start;
        } else {
            r = start;
        }

        while(l <= r) {
            int mid = l + (r-l) / 2;

            if(nums[mid] == target) {
                return mid;
            } else if(nums[mid] > target) {
                r = mid-1;
            } else {
                l = mid+1;
            }
        }
        return -1;
    }
}
