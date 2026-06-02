public class Solution {
    public int[] GetConcatenation(int[] nums) {
        
        var ans = new int[nums.Length * 2];

        for(int i = 0; i < nums.Length; i++) {
            ans[i] = nums[i];
        }

        int n = nums.Length;

        for(int i = 0; i < nums.Length; i++) {
            ans[n++] = nums[i]; 
        }

        return ans;
    }
}