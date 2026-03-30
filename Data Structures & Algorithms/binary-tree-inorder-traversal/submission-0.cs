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
        List<int> res = new List<int>();
        InOrder(root, res);
        return res;
    }

    public void InOrder(TreeNode root, List<int> numbers) {
        if(root == null) {
            return;
        }

        InOrder(root.left,numbers);
        numbers.Add(root.val);
        InOrder(root.right,numbers);
    }
}