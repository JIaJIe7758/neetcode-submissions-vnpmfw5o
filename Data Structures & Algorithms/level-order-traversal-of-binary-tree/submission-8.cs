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
    public List<List<int>> LevelOrder(TreeNode root) {
        var queue = new Queue<TreeNode>();
        var listedList = new List<List<int>>();

        if(root != null) {
            queue.Enqueue(root);
        }

        while(queue.Count > 0) {
            var list = new List<int>();
            int n = queue.Count;

            for(int i = 0; i < n; i++) {
                TreeNode node = queue.Dequeue();
                list.Add(node.val);

                if(node.left != null) {
                    queue.Enqueue(node.left);
                }

                if(node.right != null) {
                    queue.Enqueue(node.right);
                }
            } 
            listedList.Add(list);
        }

        return listedList;
    }
}
