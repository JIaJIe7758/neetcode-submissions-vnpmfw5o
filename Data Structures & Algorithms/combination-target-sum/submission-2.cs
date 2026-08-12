public class Solution {
    public List<List<int>> combs = new List<List<int>>();
    public List<List<int>> CombinationSum(int[] nums, int target) {
        
        int sum = 0;
        var curComb = new List<int>();
        Backtrack(0, nums, curComb, sum, target);
        return combs;

    }
    public void Backtrack(int i, int[] nums, List<int> curComb, int sum, int target) {
        if(sum == target) {
            combs.Add(new List<int>(curComb));
            return;
        }

        if(sum > target || i >= nums.Length) {
            return;
        }

        curComb.Add(nums[i]);
        Backtrack(i, nums, curComb, sum + nums[i], target);

        curComb.RemoveAt(curComb.Count-1);
        Backtrack(i+1, nums, curComb, sum, target);
    }
}
