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
    public int MaxDepth(TreeNode root) {
       
       var queue = new Queue<TreeNode>();
       int level = 0;

       if(root != null) {
        queue.Enqueue(root);
       }

       while(queue.Count > 0) {
            int n = queue.Count;

            for(int i = 0; i < n; i++) {
                TreeNode curr = queue.Dequeue();
                if(curr.left != null) {
                    queue.Enqueue(curr.left);
                }

                if(curr.right != null) {
                    queue.Enqueue(curr.right);
                }
            }
            level++;
       }
       return level;
    }
}
