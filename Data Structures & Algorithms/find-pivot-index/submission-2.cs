public class Solution {
    public int PivotIndex(int[] nums) {
        
        var prefix = new int[nums.Length]; //1-8-11-17-22-28  //28-27-20-17-11-6
        var suffix = new int[nums.Length];

        prefix[0] = nums[0];
        for(int i = 1; i < nums.Length; i++) {
            prefix[i] = nums[i] + prefix[i-1];
        }

        suffix[suffix.Length-1] = nums[nums.Length-1];
        for(int i = suffix.Length-2; i >= 0; i--) {
            suffix[i] = nums[i] + suffix[i+1];
        }

        for(int i = 0; i < nums.Length; i++) {
            if(prefix[i] == suffix[i]) return i;

            if(i == 0) {
                if(suffix[i+1] == 0) return i;
            }

            if(i == nums.Length-1) {
                if(prefix[i-1] == 0) return i; 
            }
        }

        return -1;


    }
}