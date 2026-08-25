public class Solution {
    List<List<int>> res;
    public List<List<int>> Permute(int[] nums) {
        
        res = new List<List<int>>();
        Backtrack(nums, new List<int>(), new bool[nums.Length]);
        return res;

    }
    public void Backtrack(int[] nums, List<int> temp, bool[] used) {
        if(temp.Count == nums.Length) {
            res.Add(new List<int>(temp));
            return;
        }

        for(int i = 0; i < nums.Length; i++) {
            if(!used[i]) {

                temp.Add(nums[i]);
                used[i] = true;
                Backtrack(nums, temp, used);
                temp.RemoveAt(temp.Count-1);
                used[i] = false;
            }
        }
    }
}
