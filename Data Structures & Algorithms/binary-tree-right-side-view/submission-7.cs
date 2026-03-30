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
    public List<int> RightSideView(TreeNode root) {
        
        var list = new List<int>();
        var queue = new Queue<TreeNode>();

        if(root != null) {
            queue.Enqueue(root);
        }

        while(queue.Count > 0) {
            TreeNode temp = null;
            int n = queue.Count;

            for(int i = 0; i < n; i++) {
                TreeNode node = queue.Dequeue();
                temp = node;

                if(node.left != null) {
                    queue.Enqueue(node.left);
                }
                if(node.right != null) {
                    queue.Enqueue(node.right);
                }
            }
            list.Add(temp.val);
        }
        return list;
    }
}
