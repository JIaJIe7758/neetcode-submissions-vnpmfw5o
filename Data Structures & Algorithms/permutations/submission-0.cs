public class Solution {
   public List<List<int>> Permute(int[] nums)
    {
        List<List<int>> ans = new List<List<int>>();

        Dfs(nums, new bool[nums.Length], new List<int>(), ans);
        return ans;
    }

    private void Dfs(int[] nums, bool[] used, List<int> path, List<List<int>> ans)
    {
        if (path.Count == nums.Length)
        {
            ans.Add(new List<int>(path));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i] == true)
                continue;

            used[i] = true;
            path.Add(nums[i]);

            Dfs(nums, used, path, ans);

            path.RemoveAt(path.Count - 1);
            used[i] = false;
        }
    }
}
