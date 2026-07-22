public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        
        int l = weights.Max();
        int r = weights.Sum();
        int res = 0;

        while(l <= r) {
            int mid = l + (r-l) / 2;

            if(IsPossible(weights, days, mid)) {
                r = mid-1;
                res = mid;
            } else {
                l = mid+1;
            }
        }

        return res;

    }

    public bool IsPossible(int[] weights, int days, int capacity) {

        int day = 1;
        int sum = 0;

        foreach(int w in weights) {
            if(sum + w > capacity) {
                day++;
                sum = w;
            } else {
                sum += w;
            }
        }

        return day <= days? true:false;
    }
}