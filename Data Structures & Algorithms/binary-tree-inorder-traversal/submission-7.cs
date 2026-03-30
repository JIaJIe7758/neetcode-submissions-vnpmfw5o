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

        InOrder(root, list);
        return list;
    }
    public void InOrder(TreeNode root, List<int> list) {
        if(root == null) {
            return;
        }

        InOrder(root.left, list);
        list.Add(root.val);
        InOrder(root.right, list);
    }
}