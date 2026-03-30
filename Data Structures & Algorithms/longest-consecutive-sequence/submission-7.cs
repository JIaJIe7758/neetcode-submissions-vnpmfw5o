public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
        int maxLength = 0;
        foreach(int i in set) {
            if(!set.Contains(i-1)) {
                int temp = i;
                int count = 0;
                while(set.Contains(temp++)) {
                    count++;
                }
                maxLength = Math.Max(count, maxLength);
            }
        }
        return maxLength;
    }
}
