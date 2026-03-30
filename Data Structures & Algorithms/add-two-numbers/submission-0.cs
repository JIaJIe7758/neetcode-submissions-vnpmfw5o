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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = null;
        ListNode current = null;
        string sum1 = "";
        string sum2 = "";

        ListNode curr1 = ReverseList(l1);
        ListNode curr2 = ReverseList(l2);

        while(curr1 != null)
        {
            sum1 += (curr1.val).ToString();
            curr1 = curr1.next;
        }
        while(curr2 != null)
        {
            sum2 += (curr2.val).ToString();
            curr2 = curr2.next;
        }

        string sum = (int.Parse(sum1) + int.Parse(sum2)).ToString();

        for(int i = sum.Length-1; i >= 0; i--)
        {
            ListNode newNode = new ListNode(sum[i] - '0');

            if (head == null)
            {
                head = newNode;
                current = head;
            }
            else
            {
                current.next = newNode;
                current = current.next;
            }
        }
        return head;

    }
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;

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
