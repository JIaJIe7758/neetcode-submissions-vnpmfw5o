public class MinStack {
    List<int> stack;
    List<int> min;
    public MinStack() {
        stack = new List<int>(); //1-2    min:1
        min = new List<int>();
    }
    
    public void Push(int val) {
        if(min.Count < 1) {
            min.Add(val);
        } else if(val <= min[min.Count-1]) {
            min.Add(val);
        }

        stack.Add(val);
    }
    
    public void Pop() {
        if(stack.Count < 1) return;
        int temp = stack[stack.Count-1];
        if(min[min.Count-1] == temp) min.RemoveAt(min.Count-1);
        stack.RemoveAt(stack.Count-1);
    }
    
    public int Top() {
        return stack[stack.Count-1];
    }
    
    public int GetMin() {
        return min[min.Count-1];
    }
}
