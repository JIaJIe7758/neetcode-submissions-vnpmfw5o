public class Solution {
    public int MySqrt(int x) { 
        
        int l = 1;
        int r = x; // 1-2-3-4-5

        while(l <= r) {
            int mid = l + (r-l) / 2;

            long xMid = (long)mid * mid;

            if(xMid > x) {
                r = mid-1;
            } else if(xMid < x) {
                l = mid +1;
            } else {
                return mid;
            }
        }
        return r;
    }
}