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
    public TreeNode DeleteNode(TreeNode root, int key) {
        TreeNode parent = null;
        TreeNode curr = root;

        while(curr != null && curr.val != key) {
            parent = curr;
            if(curr.val > key) {
                curr = curr.left;
            } else {
                curr = curr.right;
            }
        }

        if(curr == null) {
            return root;
        }

        //case2
        if(curr.left != null && curr.right != null) {
            TreeNode successor = curr.right;
            TreeNode parentSuc = curr;

            while(successor.left != null) {
                parentSuc = successor;
                successor = successor.left;
            }

            curr.val = successor.val;
            curr = successor;
            parent = parentSuc;
        }
        //case1
        TreeNode child = curr.left == null? curr.right: curr.left;

        if(parent == null) {
            return child;
        } else if(parent.left == curr) {
            parent.left = child;
        } else if(parent.right == curr){
            parent.right = child;
        }
        return root;
    }
}