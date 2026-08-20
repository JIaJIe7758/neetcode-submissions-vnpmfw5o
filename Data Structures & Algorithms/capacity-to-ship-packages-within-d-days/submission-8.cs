public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        
        int l = weights.Max();
        int r = weights.Sum();
        int res = r;

        while(l <= r) {
            int capacity = l + (r-l) / 2;

            if(IsPossible(weights, capacity, days)) {
                r = capacity-1;
                res = capacity;
            } else {
                l = capacity+1;
            }
        }

        return res;

    }
    public bool IsPossible(int[] weights, int capacity, int days) {
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