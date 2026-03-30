public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> dict = new Dictionary<int,int>();

        int n = nums.Length / 2;
        foreach(int i in nums) {
            if(!dict.ContainsKey(i)) {
                dict[i] = 1;
            }
            else {
                dict[i]++;
            }
        }

        foreach(var pair in dict) {
            if(pair.Value > n) {
                return pair.Key;
            }
        }
        return -1;
    }
}