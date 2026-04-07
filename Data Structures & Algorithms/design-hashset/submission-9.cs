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
        
        if(head == null)  {
            head = new ListNode(key);
            return;
        } else {
            ListNode curr = head;

            while(curr != null && curr.next != null) {
                if(curr.val == key) return;

                curr = curr.next;
            }

            if(curr.val != key) curr.next = new ListNode(key);
        }
    }
    
    public void Remove(int key) {

        if(Contains(key)) {
            if(head.val == key) {
                head = head.next;
            } else {
                
                ListNode curr = head;

                while(curr != null && curr.next != null) {

                    if(curr.next.val == key) {
                        curr.next = curr.next.next;
                    }

                    curr = curr.next;
                }
            }
        }
    }
    
    public bool Contains(int key) {
        
        if(head == null) return false;
        
        if(head.val == key) return true;
        ListNode curr = head;

        while(curr != null) {
            if(curr.val == key) return true;
            
            curr = curr.next;
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