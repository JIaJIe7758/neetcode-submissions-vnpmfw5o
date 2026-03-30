public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        
       int l = 1;
       int r = piles.Max(); //[1,2,3,4]
       int res = 0;

       while(l <= r) {

            int mid = l + (r-l) / 2;

            int totalHour = 0;
            foreach(int i in piles) {
                totalHour += (int)Math.Ceiling((double)i/mid);
            }

            if(totalHour <= h) {
                r = mid-1;
                res = mid;
            } else if(totalHour > h) {
                l = mid+1;
            }
       }
       return res;
    }
}
