public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var dict = new Dictionary<int,int>();

        foreach(int i in nums) {
            if(!dict.ContainsKey(i)) {
                dict[i] = 1;
            } else {
                dict[i]++;
            }
        }

        var list = new List<KeyValuePair<int,int>>(dict);
        list.Sort((x,y) => y.Value.CompareTo(x.Value));

        var res = new List<int>();

        foreach(var pair in list) {
            if(k <= 0) break;
            res.Add(pair.Key);
            k--;
        }

        return res.ToArray();
    }
}
