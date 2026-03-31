public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {

        int res = 0;
        int longest = 0;

        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] == 1) {
                res++;
            } else {
                res = 0;
            }

            longest = Math.Max(longest, res);
        }

        return longest;
    }
}