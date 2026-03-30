public class Solution {
    public int[] GetConcatenation(int[] nums)
    {
        int[] res = new int[nums.Length*2];

        for(int i = 0; i< nums.Length; i++)
        {
            res[i] = nums[i];
        }

        int j = nums.Length;
        for(int i = 0; i< nums.Length; i++)
        {
            res[j] = nums[i];
            j++;
        }

        
        return res;
    }
}