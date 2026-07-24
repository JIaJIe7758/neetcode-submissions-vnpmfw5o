public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        
        int l = 0;
        int sum = 0;
        int minLen = int.MaxValue;

        for(int r = 0; r < nums.Length; r++) {

            sum += nums[r];
            while(sum >= target) {
                minLen = Math.Min(minLen, r-l+1);
                sum -= nums[l];
                l++;
            }
        }

        return minLen == int.MaxValue? 0:minLen;
    }
}