public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        int maxLength = 0;
        foreach(int n in nums)
        {
            if(!set.Contains(n-1))
            {
                int pivot = n;
                int length = 0;  
                while(set.Contains(pivot))
                {
                    pivot++;
                    length++;
                    maxLength = Math.Max(length, maxLength);
                }
            }
        }
        return maxLength;
    }
}
