public class Solution {
    public int MinEatingSpeed(int[] piles, int h)
    {
        int l = 1;
        int r = piles.Max();
        int res = r;

        while(l <= r)
        {
            int mid = (r+l) / 2;
            int totalTime = 0;
            for(int i = 0; i < piles.Length; i++)
            {
                totalTime += (int)Math.Ceiling( piles[i] / (double)mid);  
            }

            if(totalTime <= h)
            {
                r = mid-1;
                res = mid;
            }
            else
            {
                l = mid +1;
            }
        }
        return res;
    }
}
