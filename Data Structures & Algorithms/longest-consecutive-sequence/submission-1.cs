public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> hash = new HashSet<int>(nums);
        int longest = 0;
        foreach(int n in hash)
        {
            if(!hash.Contains(n-1))
            {
                int length = 0;
                while(hash.Contains(n+length))
                {
                    length++;
                }
                longest = Math.Max(length,longest);
            }
        }
        return longest;
    }
}
