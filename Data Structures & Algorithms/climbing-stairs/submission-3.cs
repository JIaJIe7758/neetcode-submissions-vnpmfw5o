public class Solution {
    public int ClimbStairs(int n) {  
        
        //0-1-1-2-3-5-8

        if(n <= 2) return n;

        int res = 0;
        int n1 = 1;
        int n2 = 2;

        for(int i = 2; i < n; i++) {

            int temp = n1 + n2;
            n1 = n2;
            n2 = temp;
            res = temp;
        }
        return res;
    }
}
