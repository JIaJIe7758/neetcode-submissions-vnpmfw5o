public class MinStack {
    List<int> stack;
    List<int> min;
    public MinStack() {
        stack = new List<int>();
        min = new List<int>();
    }
    
    public void Push(int val) {
        if(min.Count == 0) {
            min.Add(val);
        } else if(val <= min[min.Count-1]) {
            min.Add(val);
        }

        stack.Add(val);
    }
    
    public void Pop() {
        
        if(min.Count > 0 && min[min.Count-1] == stack[stack.Count-1]) {
            stack.RemoveAt(stack.Count-1);
            min.RemoveAt(min.Count-1);
        } else {
            stack.RemoveAt(stack.Count-1);
        }
    }
    
    public int Top() {
        return stack[stack.Count-1];
    }
    
    public int GetMin() {
        return min[min.Count-1];
    }
}
