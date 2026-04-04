public class Solution {
    public int ClimbStairs(int n) {  
        
        //0-1-1-2-3-5

        if(n <= 2) return n;

        return ClimbStairs(n-1) + ClimbStairs(n-2);
    }
}
