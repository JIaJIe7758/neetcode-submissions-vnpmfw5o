public class Solution {
    public List<List<int>> Subsets(int[] nums) {

        var subSets = new List<List<int>>();
        var curSet = new List<int>();
        Helper(0, nums, curSet, subSets);
        return subSets;
    }
    public void Helper(int i, int[] nums, List<int> curSet, List<List<int>> subSets) {
        if(i >= nums.Length) {
            subSets.Add(new List<int>(curSet));
            return;
        }

        //Decisao para incluir nums[i];
        curSet.Add(nums[i]);
        Helper(i+1, nums, curSet, subSets);
        curSet.RemoveAt(curSet.Count-1);

        //Decisao para não incluir nums[i];
        Helper(i+1, nums, curSet, subSets);

    }
}
