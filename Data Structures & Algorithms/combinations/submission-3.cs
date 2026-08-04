public class Solution {
    public List<List<int>> Combine(int n, int k) {
        var curCombs = new List<int>();
        var combs = new List<List<int>>();
        Helper(1, curCombs, combs, n, k);
        return combs;
    }
    public void Helper(int i, List<int> curCombs, List<List<int>> combs, int n, int k) {
        if(curCombs.Count == k) {
            combs.Add(new List<int>(curCombs));
            return;
        }

        if(i > n) {
            return;
        }

       for(int j = i; j < n+1; j++) {
            curCombs.Add(j);
            Helper(j+1, curCombs, combs, n, k);
            curCombs.RemoveAt(curCombs.Count-1);
       }
        
    }
    
}