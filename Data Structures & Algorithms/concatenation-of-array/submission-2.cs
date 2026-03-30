public class Solution {
    public int[] GetConcatenation(int[] nums)
    {
        int l = nums.Length;
        int n = nums.Length * 2;
        int[] ans = new int[n];

        for(int i = 0; i < nums.Length; i++) {
            ans[i] = nums[i];
        }

        int temp = 0;
        for(int i = l; i < ans.Length; i++) {
            ans[i] = nums[temp++];
        }

        return ans;
    }
}