public class Solution {
    public int MinEatingSpeed(int[] piles, int h)
    {
       int l = 1;
       int r = piles.Max();
        int res = r;
       while(l <= r) {
            int mid = l + (r-l) / 2;
            int totalTime = 0;

            foreach(int i in piles) {
                totalTime += (int)Math.Ceiling(((double)i / mid));
            }

            if(totalTime <= h) {
                r = mid - 1;
                res = mid;
            } else {
                l = mid + 1;
            }
       }
       return res;
    }
}
