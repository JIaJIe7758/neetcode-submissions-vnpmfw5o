/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        
        List<int> numbers = new List<int>();

        void InOrder(TreeNode root) {
            if(root == null) {
                return;
            }

            InOrder(root.left);
            numbers.Add(root.val);
            InOrder(root.right);
        }

        InOrder(root);
        return numbers[k-1];
    }
}
