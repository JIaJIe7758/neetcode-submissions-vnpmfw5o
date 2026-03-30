public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int,int> dict = new Dictionary<int,int>();

        foreach(int n in nums){
            if(!dict.ContainsKey(n)){
                dict[n] = 1;
            }
            else{
                dict[n]++;
            }
        }

        List<KeyValuePair<int,int>> frequency = new List<KeyValuePair<int,int>>(dict);
        frequency.Sort((x,y) => y.Value.CompareTo(x.Value));
        int[] res = new int[k];

        for(int i = 0; i < res.Length; i++){
            res[i] = frequency[i].Key;
        }
        return res;
    }
}
