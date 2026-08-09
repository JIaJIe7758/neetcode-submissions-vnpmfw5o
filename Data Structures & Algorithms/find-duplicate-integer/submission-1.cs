public class Solution {
    public int FindDuplicate(int[] nums) {
       
       var set = new HashSet<int>();
       int res = -1;
       foreach(int n in nums) {
            if(set.Contains(n)) {
                res = n;
                break;
            }

            set.Add(n);
       }

       return res;


    }
}
