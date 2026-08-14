public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        int l = 0;
        var set = new HashSet<int>();

        for(int r = 0; r < nums.Length; r++) {

            if(Math.Abs(l-r) > k) {
                set.Remove(nums[l]);
                l++;
            }

            if(set.Contains(nums[r])) {
                return true;
            }

            set.Add(nums[r]);
        }
        return false;
    }
}