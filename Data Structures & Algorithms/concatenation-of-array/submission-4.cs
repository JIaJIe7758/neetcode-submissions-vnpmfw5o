public class Solution {
    public int[] GetConcatenation(int[] nums) {
        
        int[] ans = new int[nums.Length * 2];
        int n = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            ans[n++] = nums[i];
        }

        for(int i = 0; i < nums.Length; i++)
        {
            ans[n++] = nums[i];
        }

        return ans;
    }
}