public class Solution {
    public int[] SortArray(int[] nums) {
        
        return QuickSort(nums, 0, nums.Length-1);
    }

    public int[] QuickSort(int[] array, int s, int e) {
        if(e-s+1 <= 1) {
            return array;
        }

        int pivot = array[e];
        int left = s;

        for(int i = s; i < e; i++) {
            if(array[i] < pivot) {
                int temp = array[i];
                array[i] = array[left];
                array[left] = temp;
                left++;
            }
        }

        array[e] = array[left];
        array[left] = pivot;

        QuickSort(array, s, left-1);
        QuickSort(array, left+1, e);

        return array;
    }
}