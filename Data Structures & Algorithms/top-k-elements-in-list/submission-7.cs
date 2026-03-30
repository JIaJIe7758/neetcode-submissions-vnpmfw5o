public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var dict = new Dictionary<int,int>();

        foreach(int n in nums) {
            if(!dict.ContainsKey(n)) {
                dict[n] = 1;
            } else {
                dict[n]++;
            }
        }

        var list = new List<KeyValuePair<int, int>>(dict);

        list.Sort((x,y) => y.Value.CompareTo(x.Value));

        var res = new int[k];
        for(int i = 0; i < res.Length; i++) {
            res[i] = list[i].Key;
        }
        return res;
    }
}
