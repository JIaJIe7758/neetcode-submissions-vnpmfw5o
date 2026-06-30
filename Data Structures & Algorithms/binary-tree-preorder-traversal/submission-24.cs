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
        PreOrder(root, list);
        return list;
        
    }
    public void PreOrder(TreeNode root, List<int> nums) {
        if(root == null) {
            return;
        }

        nums.Add(root.val);
        PreOrder(root.left, nums);
        PreOrder(root.right, nums);
    }
}