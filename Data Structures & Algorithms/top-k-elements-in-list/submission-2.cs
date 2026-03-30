public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach(int i in nums)
        {
            if(!dict.ContainsKey(i))
            {
                dict[i] = 1;
            }
            dict[i]++;
        }

        List<KeyValuePair<int,int>> sortedPairs = new List<KeyValuePair<int,int>>(dict);
        sortedPairs.Sort((x,y) => y.Value.CompareTo(x.Value));
        int[] output = new int[k];
        for(int i = 0; i < k; i++)
        {
            output[i] = sortedPairs[i].Key;
        }
        return output;

    }
}
