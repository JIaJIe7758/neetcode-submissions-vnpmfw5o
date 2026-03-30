/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode turtle = new ListNode(0);
        turtle.next = head;
        ListNode rabit = turtle;

        
        while(rabit.next != null )
        {
            rabit = rabit.next.next;
            turtle = turtle.next;
            if(rabit == null) return false;
            if(turtle == rabit)
            {
                return true;
            }
        }
        return false;
        
    }
}
