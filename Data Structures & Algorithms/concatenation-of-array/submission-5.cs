public class Solution {
    public int[] GetConcatenation(int[] nums) {
      
      int[] ans = new int[nums.Length * 2];
      int j = 0;

      for(int i = 0; i < nums.Length; i++) {    //[1,4,1,2]
            ans[i] = nums[i];
      }

      for(int i = nums.Length; i < ans.Length; i++) {
            ans[i] = nums[j++];
      }
      return ans;
    }
}