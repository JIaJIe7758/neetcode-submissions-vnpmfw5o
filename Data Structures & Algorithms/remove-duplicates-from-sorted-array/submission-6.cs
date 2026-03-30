public class Solution {
    public int RemoveDuplicates(int[] nums) {

        int l = 0;

        for(int r = 1; r < nums.Length; r++) { //2-10-10-30-30-30
            if(nums[r] != nums[l]) {
                l++;
                nums[l] = nums[r];
            }
        }
        return l+1;
    }
}