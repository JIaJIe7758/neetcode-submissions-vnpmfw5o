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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode curr = head;
        int length = 0;

        while (curr != null)
        {
            length++;
            curr = curr.next;
        }

        curr = head;
        int stop = length-n-1;

        if(length == n)
        {
            return head.next;
        }
        else
        {
            for(int i = 0; i < stop; i++)
            {
                curr = curr.next;
            }
            curr.next = curr.next.next;
        }
        return head;
    }
}
