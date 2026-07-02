public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        
        int l = 0;
        int sum  = 0;
        int minSubArray = int.MaxValue;

        for(int r = 0; r < nums.Length; r++) {
            sum += nums[r];

            while(sum >= target) {
                minSubArray = Math.Min(minSubArray, r-l+1);
                sum -= nums[l];
                l++;
            }
        }

        return minSubArray == int.MaxValue? 0:minSubArray;
    }
}