public class Solution {
    public int ClimbStairs(int n) {     
        
        if(n <= 2) return n;

        int n1 = 1;
        int n2 = 2;
        int sum = 0;

        for(int i = 3; i <= n; i++) {
            sum = n2 + n1;
            n1 = n2;
            n2 = sum;
        }

        return sum;
    }
}
