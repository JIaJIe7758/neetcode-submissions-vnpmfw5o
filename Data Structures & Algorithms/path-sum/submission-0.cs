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
        
        var list = new List<int>();
        return Backtrack(root, list, targetSum);
    }
    public bool Backtrack(TreeNode root, List<int> list, int target) {

        if(root == null) {
            return false;
        }
        list.Add(root.val);
        int sum = list.Sum();

        if(root.left == null && root.right == null && sum == target) {
            return true;
        }

        if(Backtrack(root.left, list, target) == true) {
            return true;
        }

        if(Backtrack(root.right, list, target) == true) {
            return true;
        }

        list.RemoveAt(list.Count-1);
        return false;
    }
}