public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        //1-2-8-48
        //48-48-24-6

        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];
        int[] res = new int[nums.Length];

        prefix[0] = nums[0];
        for(int i = 1; i < prefix.Length; i++) {
            prefix[i] = prefix[i-1] * nums[i];
        }

        
        suffix[suffix.Length-1] = nums[nums.Length-1];
        for(int i = suffix.Length-2; i >= 0; i--) {
            suffix[i] = suffix[i+1] * nums[i];
        }

        for(int i = 0; i < res.Length;i++) {

            if(i == 0) res[i] = suffix[i+1];
            else if(i == res.Length-1) res[i] = prefix[i-1];
            else res[i] = prefix[i-1] * suffix[i+1];
        }

        return res;
    }
}
