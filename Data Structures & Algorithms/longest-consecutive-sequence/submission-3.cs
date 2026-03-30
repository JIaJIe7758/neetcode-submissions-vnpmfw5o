public class Solution {
    public int LongestConsecutive(int[] nums)
    {
       HashSet<int> set = new HashSet<int>(nums);
       int longest = 0;

       foreach(int i in nums)
       {
            if(!set.Contains(i-1))
            {
                int j = i;
                int count = 0;
                while(set.Contains(j++))
                {
                    count++;
                }
                longest = Math.Max(count,longest);
            }
       }
       return longest;
    }
}
