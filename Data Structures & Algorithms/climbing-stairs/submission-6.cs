public class Solution {
    public int ClimbStairs(int n) {     
        
        if(n <= 2) return n;

        int n1 = 1;
        int n2 = 2;
        int res = 0;

        for(int i = 3; i <= n; i++) {
            int temp = n1+n2;
            res = temp;
            n1 = n2;
            n2 = temp;
        }
        return res;
    }
}
