public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        HashSet<int> set = new HashSet<int>();

        int l = 0;

        for(int r = 0; r < nums.Length; r++)
        {
            set.Add(nums[r]);
            if((r-l+1) > k)
            {  
                set.Remove(nums[l]);
                l++;   
            }
            if(set.Count != (r-l+1))
            {
                return true;
            }
        }
        Console.WriteLine(set.Count);
        return false;
    }
}