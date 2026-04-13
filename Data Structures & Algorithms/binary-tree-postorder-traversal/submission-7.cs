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
       
        List<int> list = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode curr = root;

        while(curr != null || stack.Count > 0) {
            if(curr != null) {
                list.Add(curr.val);
                stack.Push(curr);
                curr = curr.right;
            } else {
                curr = stack.Pop();
                curr = curr.left;
            }
        }
        
        int l = 0;
        int r = list.Count-1;

        while(l < r) {
            int temp = list[l];
            list[l] = list[r];
            list[r] = temp;

            l++;
            r--;
        }

        return list;
    }
    
}