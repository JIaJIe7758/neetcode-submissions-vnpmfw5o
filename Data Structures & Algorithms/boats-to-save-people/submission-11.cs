public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        
        int l = 0;
        int r = people.Length-1;
        int boat = 0;

        Array.Sort(people); // 1-2-2-3-3

        while(l < r) {
            int sum = people[l] + people[r];

            if(sum <= limit) {
                boat++;
                l++;
                r--;
            } else {
                boat++;
                r--;
            }
        }

        return l == r? boat+1: boat;


    }
}