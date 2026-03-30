public class Solution {
    public int PivotIndex(int[] nums) {
        
        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];

        prefix[0] = nums[0];
        for(int i = 1; i < prefix.Length; i++) { //1-8-11-17-22-28
            prefix[i] = prefix[i-1] + nums[i];
        }

        suffix[suffix.Length-1] = nums[nums.Length-1]; ////17-11-6
        for(int i = suffix.Length-2; i >= 0; i--) {
            suffix[i] = suffix[i+1] + nums[i];
        }

        for(int i = 0; i < nums.Length; i++) {
            if(prefix[i] == suffix[i]) return i;
        }

        return -1;


    }
}