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

        //First - find the value to delete and traverse to it

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

        //Case 2 - two childrens

        if(curr.left != null && curr.right != null) {
            TreeNode parentsuc = curr;
            TreeNode successor = curr.right;

            while(successor.left != null) {
                parentsuc = successor;
                successor = successor.left;
            }

            curr.val = successor.val;
            curr = successor;
            parent = parentsuc;
        }

        //Case 1 - one children

        TreeNode children = curr.left == null? curr.right: curr.left;

        if(parent == null) {
            return children;
        } else if(parent.left == curr) {
            parent.left = children;
        } else if(parent.right == curr){
            parent.right = children;
        }

        return root;



    }
}