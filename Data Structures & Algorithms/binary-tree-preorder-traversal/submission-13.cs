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

        List<int> res = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();

        TreeNode curr = root;

        while(curr != null || stack.Count > 0) { //1-2-4-
            if(curr != null) {
                res.Add(curr.val);
                stack.Push(curr);
                curr = curr.left;
            } else {
                curr = stack.Pop();
                curr = curr.right;
            }
            
        }
        return res;
    }
}