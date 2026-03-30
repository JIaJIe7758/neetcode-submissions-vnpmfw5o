public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] sufix = new int[nums.Length];
        int[] prefix = new int[nums.Length];
        int[] result = new int[nums.Length];

        prefix[0] = nums[0];
        for(int i = 1 ; i < prefix.Length; i++)
        {
            prefix[i] = prefix[i-1] * nums[i];
        }

        sufix[nums.Length-1] = nums[nums.Length-1];
        for(int i = nums.Length-2; i>=0 ; i--)
        {
            sufix[i] = sufix[i+1] * nums[i];
        }

        for(int i = 0; i< result.Length; i++)
        {
            if(i > 0 && i < result.Length-1)
            {
                result[i] = prefix[i-1] * sufix[i+1];
            }
            else if(i == 0)
            {
                result[i] = sufix[i+1];
            }
            else
            {
                result[i] = prefix[i-1];
            }
        }
        return result;

    }
}
