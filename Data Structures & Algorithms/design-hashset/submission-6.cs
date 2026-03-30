public class ListNode {
    public int val;
    public ListNode next;

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
        if(!Contains(key)) {
            
            if(head == null) {
                head = new ListNode(key);
                return;
            }

            ListNode curr = head;
            while(curr.next != null) {
                curr = curr.next;
            }

            curr.next = new ListNode(key);
            curr = curr.next;
        }
    }
    
    public void Remove(int key) {
        if(Contains(key)) {
            if(head.val == key) {
                head = head.next;
                return;
            }

            ListNode curr = head;
            while(curr.next != null && curr.next.val != key) {
                curr = curr.next;
            }

            curr.next = curr.next.next;
        }
    }
    
    public bool Contains(int key) {
        if(head != null) {
            ListNode curr = head;

            while(curr != null) {
                if(curr.val == key) {
                    return true;
                }
                curr = curr.next;
            }
        }
        return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */