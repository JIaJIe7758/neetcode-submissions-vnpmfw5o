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
            } else if(curr.val < key) {
                curr = curr.right;
            }
        }

        if(curr == null) {
            return root;
        }

        //case 2
        if(curr.left != null && curr.right != null) {
            TreeNode sucParent = curr;
            TreeNode successor = curr.right;

            while(successor.left != null) {
                sucParent = successor;
                successor = successor.left;
            }

            curr.val = successor.val;
            curr = successor;
            parent = sucParent;
        }

        //case 1
        TreeNode child = curr.left != null? curr.left: curr.right;

        if(parent == null) {
            return child;
        } else if(parent.left == curr) {
            parent.left = child;
        } else if(parent.right == curr) {
            parent.right = child;
        }

        return root;
    }
}