public class Solution {
    public int[] GetConcatenation(int[] nums) {
        
        int[] res = new int[nums.Length * 2];
        int index = 0;

        for(int i = 0; i < nums.Length; i++) {
            res[i] = nums[index++];
        }

        for(int i = 0; i < nums.Length; i++) {
            res[index++] = nums[i];
        }

        return res;
    }
}