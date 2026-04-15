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

        var res = new List<int>();
        var list = new List<KeyValuePair<int,int>>(dict);

        list.Sort((x,y) => y.Value.CompareTo(x.Value));

        int count = 0;
        foreach(var pair in list) {
            if(count < k) {
                res.Add(pair.Key);
                count++;
            } else {
                break;
            }
        }

        return res.ToArray();

    }
}
