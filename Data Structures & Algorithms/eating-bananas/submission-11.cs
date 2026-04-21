public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        
        int l = 1;
        int r = piles.Max(); //1-2-3-4
        int res = 0;

        while(l <= r) {

            int mid = l + (r-l) / 2;
            int totalHours = 0;

            for(int i = 0; i < piles.Length; i++) {
                totalHours += (int)Math.Ceiling(piles[i] / (double)mid);
            }

            if(totalHours <= h) {
                r = mid-1;
                res = mid;
            } else {
                l = mid+1;
            }
        }

        return res;
    }
}
