public class Solution {
    public int[] SortArray(int[] nums) {
        
        if(nums.Length <= 1) { //2-1-3-5-4
            return nums;
        }

        int mid = nums.Length / 2;
        int[] leftArray = new int[mid];
        int[] rightArray = new int[nums.Length-mid];

        for(int i = 0; i < leftArray.Length; i++) {
            leftArray[i] = nums[i];
        }

        for(int i = 0; i < rightArray.Length; i++) {
            rightArray[i] = nums[mid + i];
        }

        leftArray = SortArray(leftArray);
        rightArray = SortArray(rightArray);
        return Merge(leftArray, rightArray);

    }
    public int[] Merge(int[] leftArray, int[] rightArray) {
        int[] ans = new int[leftArray.Length + rightArray.Length];
        int a = 0, r = 0, l = 0;

        while(l < leftArray.Length && r < rightArray.Length) {
            if(leftArray[l] <= rightArray[r]) {
                ans[a++] = leftArray[l++];
            } else {
                ans[a++] = rightArray[r++];
            }
        }

        while(l < leftArray.Length) {
            ans[a++] = leftArray[l++];
        }

         while(r < rightArray.Length) {
            ans[a++] = rightArray[r++];
        }

        return ans;
    
    }
}