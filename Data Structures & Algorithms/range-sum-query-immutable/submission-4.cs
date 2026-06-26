public class NumArray {
    private int[] _nums;
    private int[] prefix; 
    public NumArray(int[] nums) {
        _nums = nums;

        prefix = new int[nums.Length];

        prefix[0] = nums[0];
        for(int i = 1; i < nums.Length; i++) {
            prefix[i] = prefix[i-1] + nums[i];
        }
    }
    
    public int SumRange(int left, int right) {
        
        if(left == 0 && right != 0) {
            return prefix[right];
        } else if(left != 0 && right != 0) {
            int first = prefix[left-1];
            int second = prefix[right];
            return second - first;
        } else {
            return prefix[right];
        }


    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */