public class Solution {
    public int[] SortArray(int[] nums) {
        
        if(nums.Length <= 1) return nums;

        int mid = nums.Length / 2;
        var leftArray = new int[mid];
        var rightArray = new int[nums.Length-mid];

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
        
        var array = new int[leftArray.Length + rightArray.Length];
        int a = 0, l = 0, r = 0;

        while(l < leftArray.Length && r < rightArray.Length) {
            if(leftArray[l] <= rightArray[r]) {
                array[a++] = leftArray[l++];
            } else {
                array[a++] = rightArray[r++];
            }
        }

        while(l < leftArray.Length) {
            array[a++] = leftArray[l++];
        }

        
        while(r < rightArray.Length) {
            array[a++] = rightArray[r++];
        }

        return array;
    }
}