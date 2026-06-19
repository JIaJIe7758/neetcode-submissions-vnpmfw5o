public class Solution {
    public int[] SortArray(int[] nums) {

        return QuickSort(nums, 0, nums.Length-1);

    }
    public int[] QuickSort(int[] arr, int s, int e) {
        if(e-s+1 <= 1) {
            return arr;
        }

        int pivot = arr[e];
        int left = s;

        for(int i = s; i < e; i++) {
            if(arr[i] < pivot) {
                int temp = arr[left];
                arr[left] = arr[i];
                arr[i] = temp;
                left++;
            }
        }

        arr[e] = arr[left];
        arr[left] = pivot;

        QuickSort(arr, s, left-1);
        QuickSort(arr, left+1, e);

        return arr;
    }
}