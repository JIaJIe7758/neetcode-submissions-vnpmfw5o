public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {

        int l = 0;
        int sum = 0;
        int length = int.MaxValue;

        for(int r = 0; r < nums.Length; r++) {
            sum += nums[r];

            while(sum >= target) {
                length = Math.Min(length, (r-l+1));
                sum -= nums[l];
                l++;
            }
        }
        return length == int.MaxValue? 0: length;

    }
}