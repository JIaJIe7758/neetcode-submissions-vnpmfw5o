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
    public int GoodNodes(TreeNode root) {
        return Dfs(root,root.val);
    }
    public int Dfs(TreeNode root, int maxVal) {
        if(root == null) {
            return 0;
        }

        int res = (root.val >= maxVal) ? 1: 0;
        maxVal = Math.Max(maxVal, root.val);
        res += Dfs(root.left, maxVal);
        res += Dfs(root.right, maxVal);
        return res;
    }
}
