public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);

        int res  = 0;

        foreach(int n in nums) {
            if(!set.Contains(n-1)) {
                int length = 0;
                int num = n;
                while(set.Contains(num)) {
                    length++;
                    num++;
                }
                res = Math.Max(res, length);
            }
        }
        return res;
    }
}
