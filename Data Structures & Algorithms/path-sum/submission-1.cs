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
    public bool Backtrack(TreeNode root, int currSum, int target) {

        if(root == null) {
            return false;
        }

        currSum += root.val;

        if(root.left == null && root.right == null && currSum== target) {
            return true;
        }

        if(Backtrack(root.left, currSum, target) == true) {
            return true;
        }

        if(Backtrack(root.right, currSum, target) == true) {
            return true;
        }

        return false;
    }
}