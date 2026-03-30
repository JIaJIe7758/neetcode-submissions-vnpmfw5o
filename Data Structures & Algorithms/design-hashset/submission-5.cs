public class ListNode{
    public int val;
    public ListNode next;

    public ListNode(int val) {
        this.val = val;
        next = null;
    }
}
public class MyHashSet {
    private ListNode head;
    private int size;

    public MyHashSet() {
        head = null;
        size = 0;
    }
    
    public void Add(int key) {
        if(size == 0) {
            head = new ListNode(key);
            size++;
            return;
        }

        ListNode curr =  head;
        while(curr.next != null &&  curr.val != key) {
            curr = curr.next;
        }

        if(curr.val == key) {
            return;
        } else {
            curr.next = new ListNode(key);
            size++;
        }
    }
    
    public void Remove(int key) {
        if(head == null)  {
            return;
        }

        if(head.val == key) {
            head = head.next;
            size--;
            return;
        }

        ListNode curr = head;

        while(curr.next != null && curr.next.val != key) {
            curr = curr.next;
        }

        if (curr.next != null) { 
            curr.next = curr.next.next;
            size--;
        }
    }
    
    public bool Contains(int key) {
        if(head == null) {
            return false;
        }

        ListNode curr = head;

        while(curr != null && curr.val != key) {
            curr = curr.next;
        }

        return curr == null? false: true;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */