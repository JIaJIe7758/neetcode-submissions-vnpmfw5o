public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int[nums.Length * 2];

        int n = 0;
        for(int i = 0; i < ans.Length; i++) {

            if(i >= nums.Length) {
                ans[i] = nums[n++];
                continue;
            }
            ans[i] = nums[i];
        }

        return ans;
    }
}