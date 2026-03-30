public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
       int l = weights.Max();//3
       int r = weights.Sum();//8   [1,2,3,1,1] [3-4-5-6-7-8]

       while(l <= r) {
            int mid = l + (r-l) / 2;
            if(Possible(weights,days,mid)) {
                r = mid-1;
            } else {
                l = mid+1;
            }
       }
       return l;
    }
    public bool Possible(int[] weights, int days, int cap){
        
        int day = 1;
        int sum = 0;

        foreach(int weight in weights) {
            if(sum + weight > cap) {
                day++;
                sum = weight;
            } else {
                sum += weight;
            }
        }
        return day <= days;
    }
}