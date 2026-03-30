public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> hashes = new HashSet<int>(nums);
        int longest = 0;

        foreach(int i in hashes)
        {
            if(!hashes.Contains(i-1))
            {
                int length = 0;
                while(hashes.Contains(i + length))
                {
                    length+=1;
                }

                longest = Math.Max(length,longest);
            }
        }
        return longest;
    }
}
