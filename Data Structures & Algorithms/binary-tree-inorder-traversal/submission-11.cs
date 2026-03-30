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
    public List<int> InorderTraversal(TreeNode root) {
        var list = new List<int>();

        void InOrder(TreeNode root) {
            if(root == null) {
                return;
            }

            InOrder(root.left);
            list.Add(root.val);
            InOrder(root.right);
        }

        InOrder(root);
        return list;
    }
}