public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach(int i in nums)
        {
            if(!dict.ContainsKey(i))
            {
                dict[i] = 1;
            }
            else
            {
                dict[i]++;
            }
        }
        List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>(dict);
        list.Sort((x,y) => y.Value.CompareTo(x.Value));
        int[] output = new int[k];
        for(int i = 0; i< k; i++)
        {
            output[i] = list[i].Key;
        }
        return output;
    }
}
