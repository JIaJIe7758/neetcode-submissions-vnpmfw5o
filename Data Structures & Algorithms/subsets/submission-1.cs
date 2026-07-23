public class Solution {
    public List<List<int>> Subsets(int[] nums) {

        var currSet = new List<int>();
        var subSet = new List<List<int>>();
        Helper(0, nums, currSet, subSet);
        return subSet;
    }
    public void Helper(int i, int[] nums, List<int> currSet, List<List<int>> subSet) {
        if(i >= nums.Length) {
            subSet.Add(new List<int>(currSet));
            return;
        }

        currSet.Add(nums[i]);
        Helper(i+1, nums, currSet, subSet);
        currSet.RemoveAt(currSet.Count-1);

        Helper(i+1, nums, currSet, subSet);
    }
}
