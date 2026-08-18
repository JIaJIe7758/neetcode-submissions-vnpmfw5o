public class Solution {
    public int ClimbStairs(int n) {     
        
        if(n <= 2) {
            return n;
        }

        int n1 = 1, n2 = 2, res = 0;

        for(int i = 2; i < n; i++) {
            res = n1 + n2;
            n1 = n2;// 2 3
            n2 = res;//3 5
        }

        return res;
    }
}
