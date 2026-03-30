public class Solution {
    public List<int> MajorityElement(int[] nums) {
        Dictionary<int,int> dict = new Dictionary<int,int>();

        foreach(int i in nums) {
            if(!dict.ContainsKey(i)) {
                dict[i] = 1;
            } else {
                dict[i]++;
            }
        }

        List<int> res = new List<int>();
        int n = nums.Length;

        foreach(var pair in dict) {
            if(pair.Value > n/3) {
                res.Add(pair.Key);
            }
        }
        return res;
    }

}