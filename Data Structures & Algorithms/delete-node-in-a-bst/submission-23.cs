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
        
        TreeNode curr = root;
        TreeNode parent = null;

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

        //case 2 children

        if(curr.left != null && curr.right != null) {
            TreeNode successor = curr.right;
            TreeNode parentSuccessor = curr;

            while(successor.left != null) {
                parentSuccessor = successor;
                successor = successor.left;
            }

            curr.val = successor.val;
            curr = successor;
            parent = parentSuccessor;
        }



        //case 1 children
        TreeNode children = curr.left != null? curr.left: curr.right;

        if(parent == null) {
            return children;
        } else if(parent.left == curr) {
            parent.left = children;
        } else if(parent.right == curr) {
            parent.right = children;
        }

        return root;



    }
}