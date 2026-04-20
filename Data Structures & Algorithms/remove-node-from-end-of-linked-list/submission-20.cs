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
        ListNode curr = reversedList;

        if(n == 1) {
            reversedList = reversedList.next;
        } else {

            for(int i = 1; i < n-1; i++) {
                curr = curr.next;
            }

            curr.next = curr.next.next;
        }


        return Reverse(reversedList);
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
