public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        
        int l = 0;
        int r = people.Length-1; //
        int boats = 0;
        Array.Sort(people);

        while(l < r) {
            int weight = people[l] + people[r];
            if(weight > limit) {
                boats++;
                r--;
            } else if(weight <= limit) {
                boats++;
                l++;
                r--;
            }
        }
        return l == r? boats+1: boats;
    }
}