public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] prefix = new int[nums.Length];
        int[] sufix = new int[nums.Length];
        int[] res = new int[nums.Length];

        prefix[0] = nums[0];
        for(int i = 1; i < nums.Length; i++) {
            prefix[i] = prefix[i-1] * nums[i];
        }

        sufix[nums.Length-1] = nums[nums.Length-1];
        for(int i = nums.Length-2; i >= 0; i--) {
            sufix[i] = sufix[i+1] * nums[i];
        }
        //1,2,8,48
        //48,48,24,6

        for(int i = 0; i < res.Length; i++) {
            if( i > 0 &&  i < nums.Length-1) res[i] = sufix[i+1] * prefix[i-1];
            else if(i == 0) res[i] = sufix[i+1];
            else res[i] = prefix[i-1];
        }
        return res;
    }
}
