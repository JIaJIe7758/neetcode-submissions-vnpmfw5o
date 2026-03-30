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
        if (head == null || head.next == null) return false;

        ListNode turtle = head; // 🐢
        ListNode rabit = head;  // 🐇

        while (rabit != null && rabit.next != null)
        {
            turtle = turtle.next;
            rabit = rabit.next.next;

            if (turtle == rabit)
            {
                return true; // cycle detected
            }
        }

        return false; // reached end → no cycle
        
    }
}
