public class Solution {
    public List<List<int>> combs;
    public List<List<int>> Combine(int n, int k) {
        
        combs = new List<List<int>>();
        Helper(1, new List<int>(), n, k);
        return combs;

    }
    public void Helper(int i, List<int> curComb, int n, int k) {
        if(curComb.Count == k) {
            combs.Add(new List<int>(curComb)); //1-2  1-3
            return;
        }

        if(i > n) {
            return;
        }

        curComb.Add(i);
        Helper(i+1, curComb, n, k);

        curComb.RemoveAt(curComb.Count-1);
        Helper(i+1, curComb, n, k);
    }
}