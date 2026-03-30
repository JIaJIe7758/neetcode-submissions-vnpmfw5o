public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int,int> dict = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++) {
            if(dict.ContainsKey(target - nums[i])) {
                int first = dict[target - nums[i]];
                return new int[]{first, i};
            }
            dict[nums[i]] = i;
        }
        return new int[]{};
    }
}
