public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        var hashSet = new HashSet<int>(nums);
        int maxLength = 0;

        foreach(int i in hashSet) {
            if(!hashSet.Contains(i-1)) {
                
                int start = i;
                int count = 0;
                while(hashSet.Contains(start++)) {
                    count++;
                }
                maxLength = Math.Max(maxLength, count);
            }
        }

        return maxLength;
    }
}
