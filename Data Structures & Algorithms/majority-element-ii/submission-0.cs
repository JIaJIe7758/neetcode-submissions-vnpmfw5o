public class Solution {
    public List<int> MajorityElement(int[] nums) {
        List<int> res = new List<int>();
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int n = nums.Length / 3;
        foreach(int number in nums) {
            if(!dict.ContainsKey(number)) {
                dict[number] = 1;
            } else {
                dict[number]++;
            }
        }

        foreach(var pair in dict) {
            if(pair.Value > n) {
                res.Add(pair.Key);
            }
        }
        return res;
    }
}