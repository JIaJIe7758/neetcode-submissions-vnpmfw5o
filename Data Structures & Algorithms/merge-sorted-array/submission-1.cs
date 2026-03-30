public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        int n1 = m-1;
        int n2 = n-1;

        int res = (m+n)-1;

        while(n2 >= 0) {
            if(n1 >= 0 && nums1[n1] > nums2[n2]) {
                nums1[res--] = nums1[n1--]; 
            } else {
                nums1[res--] = nums2[n2--];
            }
        } 
    }

}