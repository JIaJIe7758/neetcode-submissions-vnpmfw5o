public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        
        Array.Sort(nums);
        var curSet = new List<int>();
        var subSet = new List<List<int>>();
        Helper(0, nums, curSet, subSet);
        return subSet;

    }

    public void Helper(int i, int[] nums, List<int> curSet, List<List<int>> subSet) {
        if(i >= nums.Length) {
            subSet.Add(new List<int>(curSet));
            return;
        }

        curSet.Add(nums[i]);
        Helper(i+1, nums, curSet, subSet);
        curSet.RemoveAt(curSet.Count-1);

        while(i + 1 < nums.Length && nums[i+1] == nums[i]) {
            i++;
        }

        Helper(i+1, nums, curSet, subSet);
    }
}
