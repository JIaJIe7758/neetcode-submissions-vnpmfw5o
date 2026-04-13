public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;

        foreach(int i in set) {

            if(!set.Contains(i-1)) {

                int temp = i;
                int count = 1;

                while(set.Contains(temp+1)) {
                    temp++;
                    count++;
                }

                longest = Math.Max(longest, count);
            }
        }

        return longest;
    }
}
