public class Solution {
    public List<List<int>> Combine(int n, int k) {
        
        var curComb = new List<int>();
        var combs = new List<List<int>>();
        Helper(1, curComb, combs, n, k);
        return combs;

    }
    public void Helper(int i, List<int> curComb, List<List<int>> combs, int n, int k) {
        if(curComb.Count == k) {
            combs.Add(new List<int>(curComb));
            return;
        }

        if(i > n) {
            return;
        }

        curComb.Add(i);
        Helper(i+1, curComb, combs, n, k);
        
        curComb.RemoveAt(curComb.Count-1);
        Helper(i+1, curComb, combs, n, k);
    }
}