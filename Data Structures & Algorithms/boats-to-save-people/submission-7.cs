public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        
        //1-2-4-5  1-2-2-3-3

        int l = 0;
        int r = people.Length-1;
        int res = 0;

        Array.Sort(people);

        while(l < r) {
            int sum = people[l] + people[r];

            if(sum > limit) {
                r--;
                res++;
            } else if(sum < limit) {
                res++;
                r--;
                l++;
            } else {
                res++;
                r--;
                l++;
            }
        }

        return l == r? res+1: res;
    }
}