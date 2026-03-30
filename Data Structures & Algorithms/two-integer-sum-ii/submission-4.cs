public class Solution {
    public int[] TwoSum(int[] numbers, int target)
    {
      int l = 0;
      int r = numbers.Length-1;

      while(l < r) {

        int temp = numbers[r] + numbers[l];
        if(temp > target) {
            r--;
        } else if(temp < target) {
            l++;
        } else {
            return new int[]{l+1, r+1};
        }
      }

      return new int[]{};
    }
    
}
