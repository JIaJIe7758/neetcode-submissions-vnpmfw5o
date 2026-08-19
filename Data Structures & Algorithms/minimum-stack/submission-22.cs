public class MinStack {
    private List<int> stack;
    private List<int> min;

    public MinStack() {
        stack = new List<int>();
        min = new List<int>();
    }
    
    public void Push(int val) {
        if(min.Count <= 0) {
            min.Add(val);
        } else if(min[min.Count-1] >= val) {
            min.Add(val);
        }

        stack.Add(val);
    }
    
    public void Pop() {
        int temp = stack[stack.Count-1];
        if(min[min.Count-1] == temp) {
            min.RemoveAt(min.Count-1);
        }

        stack.RemoveAt(stack.Count-1);
    }
    
    public int Top() {
        return stack[stack.Count-1];
    }
    
    public int GetMin() {
        return min[min.Count-1];
    }
}
