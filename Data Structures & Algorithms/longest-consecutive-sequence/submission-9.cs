public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;

        foreach(int i in set) {
            if(!set.Contains(i-1)) {

                int m = i;
                int length = 0;
                while(set.Contains(m++)) {
                    length++;
                }
                longest = Math.Max(longest,length);
            }
            
        }
        return longest;
    }
}
