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
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;

        while(curr != null)
        {
            ListNode temp = curr.next; //temp = null
            curr.next = prev;//4--3--2--1--null
            prev = curr;//4--3--2--1--null
            curr = temp;//null
        }
        return prev;
    }
}
