public class Solution {
    public int MajorityElement(int[] nums) {
       
       Dictionary<int,int> dict = new Dictionary<int,int>();

       foreach(int i in nums) {
            if(!dict.ContainsKey(i)) {
                dict[i] = 1;
            } else {
                dict[i]++;
            }
       }

       foreach(KeyValuePair<int,int> item in dict) {
            if(item.Value > nums.Length/2) {
                return item.Key;
            }
       }

       return 0;
    }
}