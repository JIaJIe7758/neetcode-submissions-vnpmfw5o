public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);

        //1-2-2-3-3 limit = 3
        //1-2-4-5 limit = 6~
        //3-3-4-5 limit = 5 1

        int l = 0;
        int r = people.Length-1;
        int boats = 0;

        while(l < r) {
            if(people[l] == limit) {
                boats++;
                l++;
            } else if(people[r] == limit) {
                boats++;
                r--;
            } else if(people[l] + people[r] <= limit) {
                boats++;
                l++;
                r--;
            } else {
                boats++;
                r--;
            }
        }

        return l == r ? boats+1: boats;
    }
}