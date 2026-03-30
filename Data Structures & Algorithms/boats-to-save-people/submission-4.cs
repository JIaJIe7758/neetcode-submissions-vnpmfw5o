public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);

        //1,2,2,3,3
        int boats = 0;
        int l = 0;
        int r = people.Length-1;

        while(l < r) {
            int temp = people[r] + people[l];
            if(temp > limit) {
                r--;
                boats++;
            } else if(temp <= limit) {
                boats++;
                l++;
                r--;
            }
        }
        return l == r? boats+1: boats;
    }
}