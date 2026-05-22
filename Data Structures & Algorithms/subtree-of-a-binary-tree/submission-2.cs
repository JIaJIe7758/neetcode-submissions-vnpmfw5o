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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        
        if(root == null) {
            return false;
        }

        if(subRoot == null) {
            return true;
        }

        if(SameTree(root, subRoot) == true) {
            return true;
        }

        return IsSubtree(root.left, subRoot) ||
            IsSubtree(root.right, subRoot);
    }

    public bool SameTree(TreeNode root, TreeNode subTree) {
        if(root == null && subTree == null) {
            return true;
        }

        if(root != null && subTree != null && root.val == subTree.val) {
            return SameTree(root.left, subTree.left) &&
                SameTree(root.right, subTree.right);
        } else {
            return false;
        }


    }
}
