public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        
        int l = weights.Max();
        int r = weights.Sum();
        int res = r;

        while(l <= r) {

            int cap = l + (r-l) / 2;

            if(Possible(weights,days,cap)) {
                res = Math.Min(res, cap);
                r = cap-1;
            } else {
                l = cap+1;
            }
        }

        return res;
    }

    public bool Possible(int[] weights, int days, int cap) {

        int day = 1;   // days = 4, cap = 10
        int sum = 0;

        foreach(int w in weights) {

            if(sum + w > cap) { //24  613 10
                day++;
                sum = w;
            } else {
                sum += w;
            }
        }

        return day <= days? true: false;
    }
}