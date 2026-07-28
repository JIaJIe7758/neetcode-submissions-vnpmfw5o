public class Node {
    public Node next;
    public Node prev;
    public string val;

    public Node(string val) {
        this.val = val;
        next = null;
        prev = null;
    }
}

public class BrowserHistory {
    private Node curr;

    public BrowserHistory(string homepage) {
        curr = new Node(homepage);
    }
    
    public void Visit(string url) {
        
        curr.next = null;
        Node node = new Node(url);
        node.prev = curr;
        curr.next = node;
        curr = curr.next;
    }
    
    public string Back(int steps) {
        while(steps > 0 && curr.prev != null) {
            curr = curr.prev;
            steps--;
        }
        return curr.val;
    }
    
    public string Forward(int steps) {
        while(steps > 0 && curr.next != null) {
            curr = curr.next;
            steps--;
        }
        return curr.val;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */