public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var dict = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++) {
            if(!dict.ContainsKey(nums[i])) {
                dict[nums[i]] = 1;
            } else {
                dict[nums[i]]++;
            }
        }

        var list = new List<KeyValuePair<int,int>>(dict);
        list.Sort((x,y) => y.Value.CompareTo(x.Value));

        var res = new int[k];
        for(int i = 0; i < k; i++) {
            res[i] = list[i].Key;
        }
        return res;
    }
}
