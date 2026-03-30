public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        int length = 0;
        var set = new HashSet<int>(nums);
        foreach(int i in nums) {
            if(!set.Contains(i-1)) {
                int temp = i;
                int l = 0;
                while(set.Contains(temp)) {
                    temp++;
                    l++;
                    length = Math.Max(length, l);
                }
            }
        }
        return length;
    }
}
