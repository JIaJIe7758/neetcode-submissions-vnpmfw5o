public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        
        Array.Sort(people);

        int l = 0; 
        int r = people.Length-1; //1-2-4-5
        int boats = 0;

        while(l < r) {
            int temp = people[l] + people[r];
            if(temp <= limit) {
                boats++;
                l++;
                r--;
            } else if(temp > limit) {
                boats++;
                r--;
            }
        }

        return l == r? boats+1: boats;
    }
}