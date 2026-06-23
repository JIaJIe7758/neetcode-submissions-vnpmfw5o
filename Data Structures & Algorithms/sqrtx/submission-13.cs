public class Solution {
    public int MySqrt(int x) {
        
        int l = 1;
        int r = x;
        int res = 0;

        while(l <= r) {
            int mid = l + (r-l) / 2;

            long test = (long)mid * mid;

            if(test == x) {
                return mid;
            } else if(test < x){
                l = mid+1;
                res = mid;
            } else {
                r = mid-1;
            }
        }

        return r;
    }
}