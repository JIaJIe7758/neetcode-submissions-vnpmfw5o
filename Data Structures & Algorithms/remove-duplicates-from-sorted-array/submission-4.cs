public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
      int k = 0;
      for(int i = 1; i < nums.Length; i++) {
        if(nums[i] != nums[k]) {
            k++;
            nums[k] = nums[i];
        }
      }
      return k+1;
    }
}