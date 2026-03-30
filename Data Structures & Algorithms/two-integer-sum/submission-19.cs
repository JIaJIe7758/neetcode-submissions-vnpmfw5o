public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++) {
            int temp = target - nums[i];
            if(!dict.ContainsKey(temp)) {
                dict[nums[i]] = i;
            } else {
                return new int[]{dict[temp], i};
            }
        }
        return new int[]{};
    }
}
