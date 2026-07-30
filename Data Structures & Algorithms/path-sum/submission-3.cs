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
    public bool HasPathSum(TreeNode root, int targetSum) {
        
        int sum = 0;
        return Backtrack(root, sum, targetSum);

    }
    public bool Backtrack(TreeNode root, int sum, int targetSum) {
        if(root == null) return false;

        sum += root.val;

        if(root.left == null && root.right == null && sum == targetSum) {
            return true;
        }

        if(Backtrack(root.left, sum, targetSum) == true) {
            return true;
        }

        if(Backtrack(root.right, sum, targetSum) == true) {
            return true;
        } 
        return false;
    }
}