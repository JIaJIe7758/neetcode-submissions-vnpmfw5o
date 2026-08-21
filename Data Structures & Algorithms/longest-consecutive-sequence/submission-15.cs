public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        var set = new HashSet<int>(nums);
        int res = 0;

        foreach(int i in set) {
            if(!set.Contains(i-1)) {
                
                int temp = i;
                int count = 1;
                while(set.Contains(temp+1)) {
                    count++;
                    temp++;
                }

                res = Math.Max(res, count);
            }
        }

        return res;
    }
}
