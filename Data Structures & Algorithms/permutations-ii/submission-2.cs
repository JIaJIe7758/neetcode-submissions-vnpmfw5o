public class Solution {
    List<List<int>> res;

    public List<List<int>> PermuteUnique(int[] nums) {
        Array.Sort(nums);
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

            //aqui se i >0 , para logo, entao used[i-1] está safe
            if(i > 0 && nums[i-1] == nums[i] && used[i-1] == false) {
                continue;
            }

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