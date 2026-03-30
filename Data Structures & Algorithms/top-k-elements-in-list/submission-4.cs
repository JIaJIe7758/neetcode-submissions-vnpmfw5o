public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int,int> dict = new Dictionary<int,int>();

        foreach(int i in nums)
        {
            if(dict.ContainsKey(i))
            {
                dict[i]++;
            }
            else
            {
                dict[i] = 1;
            }
        }
        List<KeyValuePair<int,int>> list = new List<KeyValuePair<int,int>>(dict);
        List<int> output = new List<int>();
        list.Sort((x,y) => y.Value.CompareTo(x.Value));

        for(int i = k-1; i >= 0; i--)
        {
            output.Add(list[i].Key);
        }
        return output.ToArray();
    }
}
