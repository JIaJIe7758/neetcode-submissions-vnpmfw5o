public class Solution {
    private int res = 0;
    public int SubsetXORSum(int[] nums) {
        var curSet = new List<int>();
        Helper(0, nums, curSet);
        return res;
    }
    public void Helper(int i, int[] nums, List<int> curSet) {
        if(i >= nums.Length) {

            int xorr = 0;
            foreach(int j in curSet) {
                xorr ^= j;
            }

            res += xorr;
            
            return;
        }

        curSet.Add(nums[i]);
        Helper(i+1, nums, curSet);
        curSet.RemoveAt(curSet.Count-1);

        Helper(i+1, nums, curSet);
    }
}