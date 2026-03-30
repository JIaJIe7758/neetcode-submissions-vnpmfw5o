public class Solution {
    public int[] GetConcatenation(int[] nums)
    {
        int j = nums.Length;
        int[] res = new int[j * 2];

        for(int i = 0; i < j; i++) {
            res[i] = nums[i];
        }

        int temp = 0;
        for(int i = j; i < res.Length; i++) {
            res[i] = nums[temp++];
        }

        return res;
    }
}