public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        
        int l = 0;
        double average = 0;
        int count = 0;
        int sum = 0;

        for(int r = 0; r < arr.Length; r++) {

            
            sum += arr[r];
            
            if(r - l + 1 > k) {

                sum -= arr[l];
                l++;
            }
            
            if(r-l+1 == k) {
                average = (double)sum / k;

            }
            
            Console.WriteLine(average);

            if(average >= threshold) {
                count++;
            }
        }

        return count; 
    }
}