public class ListNode {
    public ListNode next;
    public int val;

    public ListNode(int val) {
        this.val = val;
        next = null;
    }
}
public class MyHashSet {

    private ListNode head;
    public MyHashSet() {
        head = null;
    }
    
    public void Add(int key) {
        if(head == null) {
            head = new ListNode(key);
            return;
        }

        if(!Contains(key)) {
            ListNode curr = head;

            while(curr != null && curr.next != null) {
                curr = curr.next;
            }

            curr.next = new ListNode(key);
        }
    }
    
    public void Remove(int key) {
        if(Contains(key)) {
            if(head.val == key) {
                head = head.next;
                return;
            }
            ListNode curr = head;

            while(curr != null && curr.next.val != key) {
                curr = curr.next;
            }
            curr.next = curr.next.next;

        }
    }
    
    public bool Contains(int key) {
        if(head == null) return false;
        if(head.val == key) return true;

        ListNode curr = head;

        while(curr != null && curr.val != key) {
            curr = curr.next;
        }

        return curr != null;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */