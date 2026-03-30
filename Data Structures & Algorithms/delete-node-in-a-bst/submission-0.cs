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

        //finding the node to delete
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

        //case 3: node has two childrens

        if(curr.left != null && curr.right != null) {
            TreeNode successor = curr.right;
            TreeNode sucParent = curr;

            while(successor.left != null) {
                sucParent = successor;
                successor = curr.left;
            }

            curr.val = successor.val;

            curr = successor;
            parent = sucParent;
        }


        //case 1 and 2: node has no childrens or only 1 children
        
        TreeNode child = curr.left != null? curr.left: curr.right;

        if(parent == null) { //if the node to delete is root node
            return child;
        } else if(parent.left == curr) {
            parent.left = child;
        } else {
            parent.right = child;
        }
        return root;
    }
}