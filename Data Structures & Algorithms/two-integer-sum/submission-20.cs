public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            int temp = target - nums[i];
            if(dict.ContainsKey(temp)) {
                return new int[]{dict[temp], i};
            } else {
                dict[nums[i]] = i;
            }
        }

        return new int[]{};
    }
}
