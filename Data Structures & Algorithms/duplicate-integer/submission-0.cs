public class Solution {
    public bool hasDuplicate(int[] nums)
    {
        HashSet<int> noDuplicates = new HashSet<int>();
        foreach(int i in nums)
        {
            noDuplicates.Add(i);
        }
        return nums.Length != noDuplicates.Count;
    }
}
