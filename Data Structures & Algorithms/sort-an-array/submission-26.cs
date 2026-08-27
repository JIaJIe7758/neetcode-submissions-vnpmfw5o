public class Solution {
    public int[] SortArray(int[] nums) {
        Quicksort(nums, 0, nums.Length-1);
        return nums;
    }
    public void Quicksort(int[] nums, int s, int e) { //2,1,3,10,5
        if(e-s+1 <= 1) {
            return;
        }

        int left = s;
        int pivot = nums[e];

        for(int i = s; i < nums.Length; i++) {
            if(nums[i] < pivot) {
                int temp = nums[i];
                nums[i] = nums[left];
                nums[left] = temp;
                left++;
            }
        }

        nums[e] = nums[left];
        nums[left] = pivot;

        Quicksort(nums, s, left-1);
        Quicksort(nums, left+1, e);

    }
}