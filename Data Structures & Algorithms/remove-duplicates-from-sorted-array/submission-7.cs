public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        int l = 0;

        for(int r = 0; r < nums.Length; r++) {

            if(nums[l] != nums[r]) {
                l++;
                nums[l] = nums[r];
            }
        }

        return l+1;
    }
}