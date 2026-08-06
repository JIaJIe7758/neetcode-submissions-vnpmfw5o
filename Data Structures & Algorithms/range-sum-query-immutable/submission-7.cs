public class NumArray {
    public int[] nums;
    private int[] prefix;
    public NumArray(int[] nums) {
        this.nums = nums;
        prefix = new int[nums.Length];
        prefix[0] = nums[0];

        for(int i = 1; i < nums.Length; i++) {
            prefix[i] = prefix[i-1] + nums[i];
        }
    }
                                                //1-2-3-4
    public int SumRange(int left, int right) {// 1-3-6-10

        int preRight = prefix[right];
        int preLeft = left-1 >= 0? prefix[left-1]:0;
        return preRight - preLeft;
        

    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */