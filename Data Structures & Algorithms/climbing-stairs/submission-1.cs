public class Solution {
    public int ClimbStairs(int n) {  
        if(n <= 2) {
            return n;
        }   

        int n1 = 1;
        int n2 = 2;
        int res = 0;
        for(int i = 2; i < n; i++) {
            res = n1 + n2;
            int temp = n2;
            n2 = res;
            n1 = temp;
        }
        return res;
    }
}
