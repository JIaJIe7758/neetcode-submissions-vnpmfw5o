public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        
        int l = weights.Max();
        int r = weights.Sum();

        int res = 0;

        while(l <= r) {
            int mid = l + (r-l) / 2;

            if(Capacity(weights, days, mid)) {
                r = mid-1;
                res = mid;
            } else {
                l = mid +1;
            }
        }
        return res;

    }
    public bool Capacity(int[] weights, int days, int cap) {
        int day = 1;
        int sum = 0;

        foreach(int w in weights) {
            if(sum + w > cap) {
                day++;
                sum = w;
            } else {
                sum += w;
            }
        }

        return day <= days? true:false;
    }
}