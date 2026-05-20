public class Solution {
    public void SortColors(int[] nums) {
        // este fixed bucket sort so funciona quando começa do 0
        // e incrementa 1 a 1, e sabemos quais sao os valores no input array
        
        var count = new int[3];

        foreach(int n in nums) {
            count[n] += 1; 
        }

        int i = 0;
        for(int n = 0; n < count.Length; n++) {
            for(int j = 0; j < count[n]; j++) {
                nums[i++] = n;
            }
        }
    }
}