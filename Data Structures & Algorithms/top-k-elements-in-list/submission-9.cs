public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int,int> dict = new Dictionary<int,int>();

        foreach(int n in nums) {
            if(!dict.ContainsKey(n)) {
                dict[n] = 1;
            } else {
                dict[n]++;
            }
        }

        List<KeyValuePair<int,int>> list = new List<KeyValuePair<int,int>>(dict);
        list.Sort((a,b) => b.Value.CompareTo(a.Value));

        var res = new int[k];
        for(int i = 0; i < k; i++) {
            res[i] = list[i].Key;
        }
        return res;
    }
}
