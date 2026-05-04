public class Solution {
    public int[] GetConcatenation(int[] nums) {
        
        var res = new int[nums.Length*2];

        int n = 0;

        for(n = 0; n < nums.Length; n++) {
            res[n] = nums[n];
        }

        for(int i = 0; i < nums.Length; i++) {
            res[n++] = nums[i];
        }

        return res;
    }
}