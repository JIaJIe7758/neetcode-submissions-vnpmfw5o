public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int l = 0;
        int count = 0; 
        int sum = 0;

        for(int r = 0; r < arr.Length; r++)
        {
            sum += arr[r];
            if((r-l + 1) == k)
            {
                double average = sum / (r-l +1);
                if(average >= threshold)
                {
                    count++;
                }
                sum -= arr[l];
                l++; 
            }
        }
        return count;
    }
}