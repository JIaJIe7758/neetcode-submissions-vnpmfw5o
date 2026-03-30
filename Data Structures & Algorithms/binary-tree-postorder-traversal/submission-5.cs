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
    public List<int> PostorderTraversal(TreeNode root) {
        var stack = new Stack<TreeNode>();
        var list = new List<int>();
        TreeNode curr = root;

        while(curr != null || stack.Count > 0) {
            if(curr != null) {
                stack.Push(curr);
                list.Add(curr.val);
                curr = curr.right;
            } else {
                curr = stack.Pop();
                curr = curr.left;
            }
        }
        list.Reverse();
        return list;
    }
}