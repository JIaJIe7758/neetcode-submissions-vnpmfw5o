public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var set = new HashSet<int>();
        int l = 0;

        for(int r = 0; r < nums.Length; r++) {
            if(Math.Abs(l-r) > k) {
                set.Remove(nums[l]);
                l++;
            }

            if(set.Add(nums[r]) == false) {
                return true;
            }
        }
        return false;
    }
}