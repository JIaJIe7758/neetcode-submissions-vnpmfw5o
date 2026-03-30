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
        if(head == null || head.next == null) {
            return null;
        }

        ListNode reversed = ReverseList(head);
        if(n == 1) {
         reversed = reversed.next;
         return ReverseList(reversed);
        }
        else {
            ListNode curr2 = reversed;

            for(int i = 1; i < n-1; i++) {
                curr2 = curr2.next;
            }
            curr2.next = curr2.next.next;

            return ReverseList(reversed);

        }

        

    }
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;    //[null ,1,2,3,4]

        while(curr != null)
        {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        return prev;
    }
}
