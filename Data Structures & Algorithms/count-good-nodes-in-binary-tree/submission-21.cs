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
        
        var queue = new Queue<(TreeNode, int)>();
        int res = 0;

        if(root != null) queue.Enqueue((root, int.MinValue));

        while(queue.Count > 0) {
            int n = queue.Count;
            var (node, max) = queue.Dequeue();

            if(node.val >= max) {
                res++;
            }

            if(node.left != null) queue.Enqueue((node.left, Math.Max(node.val, max)));
            if(node.right != null) queue.Enqueue((node.right, Math.Max(node.val, max)));
        }
        return res;
    }
}
