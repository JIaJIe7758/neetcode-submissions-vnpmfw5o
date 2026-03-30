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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        if(root == null) {
            return new TreeNode(val);
        }

        TreeNode curr = root;
        if(curr.val < val) {
            curr.right = InsertIntoBST(root.right, val);
        } else if(curr.val > val) {
            curr.left = InsertIntoBST(root.left, val);
        }
        return root;
    }
}