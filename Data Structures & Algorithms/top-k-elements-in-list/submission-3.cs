public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach(int i in nums)
        {
            if(!dict.ContainsKey(i)) dict[i] = 1;
            else dict[i]++;
        }
        int[] output = new int[k];
        List<KeyValuePair<int,int>>frequency = new List<KeyValuePair<int,int>>(dict);
        frequency.Sort((x,y) => y.Value.CompareTo(x.Value));
        for(int i = 0; i < k; i++)
        {
            output[i] = frequency[i].Key;
        }
        return output;
    }
}
