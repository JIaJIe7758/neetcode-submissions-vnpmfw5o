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
        
        return Dfs(root, root.val);

    }
    public int Dfs(TreeNode root, int max) {
        if(root == null) return 0;

        int res = root.val >= max? 1:0;
        max = Math.Max(max, root.val);
        res += Dfs(root.left, max);
        res += Dfs(root.right, max);
        return res; 
    }
}
