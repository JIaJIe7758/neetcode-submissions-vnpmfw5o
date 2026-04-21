public class Solution {
    public List<int> MajorityElement(int[] nums) {
        
        var dict = new Dictionary<int,int>();
        var list = new List<int>();

        foreach(int i in nums) {

            if(!dict.ContainsKey(i)) {
                dict[i] = 1;
            } else {
                dict[i]++;
            }

        }

        int cup = nums.Length/3;

        foreach(var pair in dict) {
            if(pair.Value > cup) list.Add(pair.Key);
            Console.WriteLine(pair.Value);
        }

        return list;
    }
}