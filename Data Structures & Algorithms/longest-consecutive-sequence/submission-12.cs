public class Solution {
    public int LongestConsecutive(int[] nums) {
         var set = new HashSet<int>(nums);
        int longest = 0;

        foreach(int n in set) {
            if(!set.Contains(n-1)) {
                int count = 1;
                int temp = n;
                while(set.Contains(temp+1)){
                    count++;
                    temp++;
                }

                longest = Math.Max(longest, count);
            }
        }

        return longest;

    }
}
