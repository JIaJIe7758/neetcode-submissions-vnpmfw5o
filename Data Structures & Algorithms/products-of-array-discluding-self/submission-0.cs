public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] array = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            int sum = 1;
            for(int j = 0; j < nums.Length; j++)
            {
                if(j == i) continue;
                sum *= nums[j];
            }
            array[i] = sum;
        }
        return array;
    }
}
