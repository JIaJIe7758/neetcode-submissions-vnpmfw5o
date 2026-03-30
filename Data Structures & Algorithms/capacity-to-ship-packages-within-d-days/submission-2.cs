public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
       int l = weights.Max();
       int r = weights.Sum();

       while(l <= r) {

            int mid = l + (r-l) / 2;

            if(Possible(weights,days,mid)) { 
                r = mid-1;
            } else {
                l = mid +1;
            }
       }
       return l;

    }
    public bool Possible(int[] weights, int days, int cap){
        int day = 1;
        int sum = 0;
        foreach(int w in weights) {
            if(w + sum > cap) {
                day++;
                sum = w;
            } else {
                sum += w; //sum =       , day = 1 
            }
        }
        return day <= days;
       
    }
}