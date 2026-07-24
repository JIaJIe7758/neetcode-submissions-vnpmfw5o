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

        

        for(int j = i; j < n+1; j++) {
            curComb.Add(j);
            Helper(j+1, curComb, combs, n, k);
            curComb.RemoveAt(curComb.Count-1);
        }
    }
}