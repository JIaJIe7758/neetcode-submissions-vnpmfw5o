public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        
        int l = 1;
        int r = 0;
        int res = 0;
        foreach(int p in piles) {
            if(p > r) r = p;
        }

        while(l <= r) {

            int mid = l + (r-l) / 2;
            
            int totalHours = 0;
            for(int i = 0; i < piles.Length; i++) {
                totalHours += (int)Math.Ceiling((double)piles[i] / mid);
            }

            if(totalHours <= h) {
                res = mid;
                r = mid-1;
            } else {
                l = mid+1;
            }
        }

        return res;
    }
}
