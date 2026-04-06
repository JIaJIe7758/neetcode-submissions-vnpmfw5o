public class Solution {
    public int[] SortArray(int[] nums) {

        if(nums.Length <= 1) return nums;
        
        int mid = nums.Length / 2;
        int[] leftArray = new int[mid];
        int[] rightArray = new int[nums.Length-mid];

        for(int i = 0; i < mid; i++) {
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

        int[] arr = new int[leftArray.Length + rightArray.Length];

        int l = 0, r = 0, a = 0;

        while(l < leftArray.Length && r < rightArray.Length) {
            if(leftArray[l] <= rightArray[r]) {
                arr[a++] = leftArray[l++];
            } else {
                arr[a++] = rightArray[r++];
            }
        }

        while(l < leftArray.Length) {
            arr[a++] = leftArray[l++];
        }

        
        while(r < rightArray.Length) {
            arr[a++] = rightArray[r++];
        }

        return arr;
    }
}