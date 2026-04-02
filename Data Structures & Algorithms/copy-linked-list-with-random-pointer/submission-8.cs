/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
       
       Node curr = head;
       Dictionary<Node, Node> dict = new Dictionary<Node, Node>();

       while(curr != null) {
            Node node = new Node(curr.val);
            dict[curr] = node;

            curr = curr.next;
       }

       curr = head;

       while(curr != null) {
            
            dict[curr].next = curr.next != null? dict[curr.next]: null;
            dict[curr].random = curr.random != null? dict[curr.random]: null;

            curr = curr.next;
       }
       return head != null ? dict[head]:head;
    }
}
