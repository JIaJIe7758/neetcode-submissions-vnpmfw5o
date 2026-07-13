public class Solution {
    public int Search(int[] nums, int target) {
        
        int l  = 0;
        int r  = nums.Length-1;

        while(l < r) {
            int mid = l + (r-l) / 2;

            if(nums[mid] > nums[r]) {
                l = mid+1;
            } else if(nums[mid] < nums[r]) {
                r = mid;
            }
        }

        int smallest = l;
        l = 0;
        r = nums.Length-1;

        if(nums[smallest] <= target && nums[r] >= target) {
            l = smallest;
        } else {
            r = smallest-1;
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
