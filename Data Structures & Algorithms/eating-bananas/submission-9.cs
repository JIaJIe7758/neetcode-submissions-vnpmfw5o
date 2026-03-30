public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        
        int l = 1;
        int r = piles.Max();
        int res = r;

        while(l < r) {
            int mid = l + (r-l) / 2;
            int totalHours = 0;
            for(int i = 0; i < piles.Length; i++) {
                totalHours += (int)Math.Ceiling((double)piles[i] / mid);
            }

            if(totalHours <= h) {
                r = mid;
                res = r;
            } else {
                l = mid+1;
               
            }
        }
        return res;
    }
}
