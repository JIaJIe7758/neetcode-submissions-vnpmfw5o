public class Solution {
    public int MinEatingSpeed(int[] piles, int h)
    {
       int l = 1;
       int r = piles.Max();
       while(l <= r) { //1-2-3-4

            int mid = l + (r-l) / 2; 
            int totalTime = 0;
            foreach(int i in piles) {
                totalTime += (int)Math.Ceiling(((double)i / mid));
            }
            Console.WriteLine(totalTime);
            if(totalTime <= h) {
                r = mid-1;
            } else {
                l = mid+1;
            }
       }
       return l;
    }
}
