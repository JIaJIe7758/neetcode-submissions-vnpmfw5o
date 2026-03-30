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
        
        var listList = new List<List<int>>();

        void BFS(TreeNode root) {

            var queue = new Queue<TreeNode>();
            var list = new List<int>();

            if(root != null) {
                queue.Enqueue(root);
            }
            
            while(queue.Count > 0) {
                int n = queue.Count();
                for(int i = 0; i < n; i++) {
                    TreeNode curr = queue.Dequeue();
                    list.Add(curr.val);
                    if(curr.left != null) {
                        queue.Enqueue(curr.left);
                    }
                    if(curr.right != null) {
                        queue.Enqueue(curr.right);
                    }
                }
                listList.Add(list);
                list = new List<int>();
            }
        }
        BFS(root);
        return listList;
    }
}
