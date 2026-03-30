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
    public List<int> PreorderTraversal(TreeNode root) {
        var list = new List<int>();

        var stack = new Stack<TreeNode>();

        TreeNode curr = root;

        while(curr != null || stack.Count > 0) {
            if(curr != null) {
                list.Add(curr.val);
                stack.Push(curr.right);
                curr = curr.left;
            } else {
                curr = stack.Pop();
            }
        }
        return list;
    }
}