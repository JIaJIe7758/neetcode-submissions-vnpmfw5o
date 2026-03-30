public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0;
        int r = numbers.Length-1;

        while(l < r) {
            int calc = numbers[l] + numbers[r];
            if(calc == target) {
                return new int[]{l+1, r+1};
            } else if(calc > target) {
                r--;
            } else {
                l++;
            }
        }

        return new int[]{};
    }
}
