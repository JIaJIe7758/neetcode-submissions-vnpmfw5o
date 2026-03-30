public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        HashSet<int> set = new HashSet<int>();
        int l = 0;

        for(int r = 0; r < nums.Length; r++) {

            if((Math.Abs(l-r)) > k) {
                set.Remove(nums[l]);
                l++;
            }

            if(set.Contains(nums[r])) { //1-2-
                return true;
            }

            set.Add(nums[r]);
        }

        return false;

    }
}