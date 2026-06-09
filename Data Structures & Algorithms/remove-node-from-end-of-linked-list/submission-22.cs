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
        
        ListNode reversedList = Reverse(head);

        if(head == null) return head;
        if(n == 1) {
            reversedList = reversedList.next;
        } else {
            ListNode curr = reversedList;
            for(int i = 0; i < n-2; i++) {
                curr = curr.next;
            }
            curr.next = curr.next.next;
        }
        return Reverse(reversedList);
    }

    public ListNode Reverse(ListNode head) {

        ListNode prev = null;
        ListNode curr = head; //1-2-3-4-null

        while(curr != null) {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        return prev;
    }
}
