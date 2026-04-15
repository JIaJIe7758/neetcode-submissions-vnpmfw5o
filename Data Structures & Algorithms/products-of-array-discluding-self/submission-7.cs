public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        var prefix = new int[nums.Length];
        var suffix = new int[nums.Length];
        var res = new int[nums.Length];

        prefix[0] = nums[0];
        for(int i = 1; i < nums.Length; i++) {
            prefix[i] = prefix[i-1] * nums[i];
        }

        suffix[suffix.Length-1] = nums[nums.Length-1];
        for(int i = suffix.Length-2; i >= 0; i--) {
            suffix[i] = suffix[i+1] * nums[i];
        }

        for(int i = 0; i < res.Length; i++) {
            if(i == 0) res[i] = suffix[i+1];
            else if(i == res.Length-1) res[i] = prefix[i-1];
            else res[i] = suffix[i+1] * prefix[i-1];
        }

        return res;
    }
}
