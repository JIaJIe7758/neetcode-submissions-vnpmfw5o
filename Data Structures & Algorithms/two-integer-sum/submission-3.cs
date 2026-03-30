public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int sub = target - nums[i];
            if(dic.ContainsKey(sub))
            {
                return new int[]{dic[sub], i};
            }
            else
            {
                dic[nums[i]] = i;
            }
        }
        return new int[]{};
    }
}
