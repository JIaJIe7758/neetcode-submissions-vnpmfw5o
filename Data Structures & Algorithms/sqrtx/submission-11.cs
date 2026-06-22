public class Solution {
    public int MySqrt(int x) {
        
        int l = 1; //1-2-3-4-5-6
        int r = x;
        int res = 0;

        while(l <= r) {

            int mid = l + (r-l) / 2;

            long squareMid = (long)mid * mid;

            if(squareMid == x) {
                return mid;
            } else if(squareMid < x) {
                l = mid+1;
                res = mid;
            } else {
                r = mid-1;
            }
        }

        return res;
    }

}