public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
       HashSet<int> set = new HashSet<int>();

       int l = 0;


       for(int r = 0; r < nums.Length; r++) {
            int count = Math.Abs(l-r);

            if(count > k) {
                set.Remove(nums[l]);
                l++;
            }

            if(!set.Add(nums[r])) {
                return true;
            }
       }
       return false;
    }
}