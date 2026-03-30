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

public class Solution { //[4-3-2-1]
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
       ListNode reversedHead = ReverseList(head);
       ListNode curr = reversedHead;

       if(curr.next == null || n == 1) { //3-2-1
            reversedHead = reversedHead.next;
       } else {
            for(int i = 1; i < n-1; i++) {
                curr = curr.next;
            }
            curr.next = curr.next.next;
       }
       return ReverseList(reversedHead);

    }
    public ListNode ReverseList(ListNode head)
    {
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
