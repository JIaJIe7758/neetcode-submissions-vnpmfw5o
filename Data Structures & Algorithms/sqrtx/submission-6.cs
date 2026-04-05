public class Solution {
    public int MySqrt(int x) { 
        if(x == 1) {
            return 1;
        }

        int r = x/2;   //[1,2,3,4,5,6] x = 13 = 3.6
        int l = 1;

        while(l <= r) {
            int mid = l + (r-l) / 2;
            long pow = (long)mid * mid;
            if(pow == x) {
                return mid;
            } else if(pow < x) {
                l = mid +1;
            } else {
                r = mid -1;
            }

        }  
        return r;
    }
}