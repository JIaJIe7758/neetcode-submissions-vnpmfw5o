public class NumArray {

    private int[]_nums;
    private int[] prefix;

    public NumArray(int[] nums) {
        _nums = nums;

        prefix = new int[_nums.Length];
        
        
        prefix[0] = _nums[0]; //1-2-3-4
        for(int i = 1; i < prefix.Length;i++) {
            prefix[i] = prefix[i-1] + _nums[i];//1-3-6-10
        }
    }
    
    public int SumRange(int left, int right) {
        
        int preRight = prefix[right];
        int preLeft = (left - 1) < 0? 0:prefix[left-1];
        return preRight - preLeft;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */