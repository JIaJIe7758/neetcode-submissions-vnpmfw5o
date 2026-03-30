public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        foreach(int i in nums) {
            if(set.Add(i) == false) {
                return i;
            }
        }
        return 0;
    }
}
