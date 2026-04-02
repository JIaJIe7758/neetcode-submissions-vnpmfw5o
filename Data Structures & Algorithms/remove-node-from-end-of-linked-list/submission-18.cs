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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        ListNode newHead = Reverse(head); //4-3-2-1
        ListNode toRemove = newHead;
        ListNode curr = newHead;

        if(n == 1) {
            newHead = newHead.next;
            return Reverse(newHead);
        }

        for(int i = 0; i < n-1; i++) {
            toRemove = toRemove.next;
        }

        while(curr != null && curr.next != null) {
            if(curr.next == toRemove) {
                curr.next = curr.next.next;
                break;
            } else {
                curr = curr.next;
            }
            
        }

        return Reverse(newHead); //7-8-2-8


    }
    public ListNode Reverse(ListNode head) {
        
        ListNode prev = null;
        ListNode curr = head;

        while(curr != null) {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        return prev;
    }
}
