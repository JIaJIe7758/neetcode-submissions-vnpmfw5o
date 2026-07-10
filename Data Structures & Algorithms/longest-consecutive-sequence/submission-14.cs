public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        var set = new HashSet<int>(nums);
        int longest = 0;

        foreach(int n in nums) {
            if(!set.Contains(n-1)) {

                int temp = n;
                int count = 1;
                while(set.Contains(temp+1)) {
                    count++;
                    temp++;
                }

                longest = Math.Max(longest, count);
            }
        }

        return longest;
    }
}
