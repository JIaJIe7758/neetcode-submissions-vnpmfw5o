public class Solution {
    List<List<int>> res;
    public List<List<int>> Permute(int[] nums) {
        var set = new HashSet<int>();
        res = new List<List<int>>();
        Backtrack(set, nums);
        return res;
    }

    private void Backtrack(HashSet<int> perm, int[] nums) {
        if (perm.Count == nums.Length) {
            res.Add(new List<int>(perm));
            return;
        }
        for (int i = 0; i < nums.Length; i++) { //[,] 
            if (perm.Contains(nums[i])) {
                continue;
            }

            perm.Add(nums[i]);
                
            Backtrack(perm, nums);
            perm.Remove(nums[i]);
        }
    }
}