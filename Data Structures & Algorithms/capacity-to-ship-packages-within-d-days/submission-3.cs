public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int l = weights.Max();
        int r = weights.Sum();
        int res = r;
        while(l < r) {
            int cap = l + (r-l) / 2;

            if(Possible(weights, days, cap)) {
                r = cap;
                res = r;
            } else {
                l = cap+1;
            }
        }
        return res;

    }
    public bool Possible(int[] weights, int days, int cap){
        int day = 1;
        int sum = 0;

        foreach(int weight in weights) {
            if(sum + weight <= cap) {
                sum += weight;
            } else {
                day++;
                sum = weight;
            }
        }
        return day <= days? true: false;
    }
}