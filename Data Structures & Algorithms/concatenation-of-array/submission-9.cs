public class Solution {
    public int[] GetConcatenation(int[] nums) {
        
        var res = new int[nums.Length * 2];

        int n = nums.Length;
        for(int i = 0; i < nums.Length; i++) {
            res[i] = nums[i];
        }

        for(int i = 0; i < nums.Length; i++) {
            res[n++] = nums[i];
        }

        return res;
    }
}