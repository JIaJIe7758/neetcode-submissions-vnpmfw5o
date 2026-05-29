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
    public bool IsValidBST(TreeNode root) {
        
        return IsValid(root, long.MinValue, long.MaxValue);

    }

    public bool IsValid(TreeNode root, long left, long right) {
        if(root == null) return true;

        if(!(left < root.val && root.val < right)) {
            return false;
        }

        return IsValid(root.left, left, root.val) &&
            IsValid(root.right, root.val, right);
    }
}
