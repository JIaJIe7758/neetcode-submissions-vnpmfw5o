public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
         int l = weights.Max();//3
        int r = weights.Sum(); //8  days = 2
        int res = r;       //1,2,3,1,1   [3-4-5-6-7-8]
        //

        while(l < r) {
            int mid =  l + (r-l) / 2;
            if(Possible(weights,days,mid)) {
                r = mid;
                res = r;
            } else {
                l = mid+1;
            }
        }
        return res;
    }
    public bool Possible(int[] weights, int days, int cap){
        
        int day = 1;
        int currLoad = 0;
        for (int i = 0; i < weights.Length; i++) {
            if (currLoad + weights[i] > cap) {
                day++;
                currLoad = weights[i];
            } else {
                currLoad += weights[i];
            }
        }
        return day <= days;
    }
}