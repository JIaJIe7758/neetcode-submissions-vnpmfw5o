public class Solution {
    public int[] SortArray(int[] nums) {

        return QuickSort(nums, 0, nums.Length-1);
        

    }

    public int[] QuickSort(int[] nums, int s, int e) {
        
        if(e-s+1 <= 1) {
            return nums;
        }

        int pivot = nums[e];
        int left = s;

        for(int i = s; i < nums.Length; i++) {

            if(nums[i] < pivot) {
                int temp = nums[left];
                nums[left] = nums[i];
                nums[i] = temp;
                left++;
            }
        }

        nums[e] = nums[left];
        nums[left] = pivot;

        QuickSort(nums, s, left-1);
        QuickSort(nums, left+1, e);

        return nums;

    }


}