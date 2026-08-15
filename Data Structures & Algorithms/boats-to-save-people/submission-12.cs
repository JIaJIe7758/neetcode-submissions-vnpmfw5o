public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        
        Array.Sort(people);
        int l = 0;
        int r = people.Length-1;
        int boats = 0;

        while(l < r) { // 1-2-1-3-3
            int temp = people[l] + people[r];

            if(temp == limit) {
                boats += 1;
                l++;
                r--;
            } else if(temp > limit) {
                boats += 1;
                r--;
            } else {
                boats += 1;
                l++;
                r--;
            }
        }

        return l == r? boats + 1: boats;
    }
}