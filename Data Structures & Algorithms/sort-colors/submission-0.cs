public class Solution {
    public void SortColors(int[] nums) {

        // este fixed bucket sort so funciona quando começa do 0
        // e incrementa 1 a 1, e sabemos quais sao os valores no input array
        
        int[] counts = new int[]{0,0,0};

        foreach(int n in nums) { //counts = 1-2-1
            counts[n] += 1;
        }

        int i = 0;
        for(int n = 0; n < counts.Length; n++) {
            for(int j = 0; j < counts[n]; j++) { //0-1-1-2
                nums[i] = n;
                i++;
            }
        }

    }
}