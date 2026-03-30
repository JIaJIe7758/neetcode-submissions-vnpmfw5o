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
    public ListNode ReverseList(ListNode head) //0-1-2-3-null 
    {
       ListNode curr = head;
       ListNode prev = null;

       while(curr != null) {
            ListNode temp = curr.next;//null>0>1>2>3>null
            curr.next = prev; //0-null
            prev = curr;  //
            curr = temp;
       }
       return prev;


    }
}
