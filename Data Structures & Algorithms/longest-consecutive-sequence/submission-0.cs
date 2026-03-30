public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> integers = new HashSet<int>(nums);
        int longest = 0;
        foreach(int n in nums)
        {
            if(!integers.Contains(n-1))
            {
                int length = 1;
                while(integers.Contains(n + length))
                {
                    length++;
                }
                longest = Math.Max(longest,length);
            }
        }
        return longest;
    }
}
