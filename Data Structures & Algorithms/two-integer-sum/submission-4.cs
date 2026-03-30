public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        List<int> indexes = new List<int>();
        for(int i = 0; i< nums.Length; i++)
        {
            if(dict.ContainsKey(target - nums[i]))
            {
                indexes.Add(dict[target - nums[i]]);
                indexes.Add(i);
            }
            dict[nums[i]] = i;
        }
        return indexes.ToArray();

    }
}
