public class MinStack {
    List<int> stack;
    List<int> min;

    public MinStack() {
      stack = new List<int>();
      min = new List<int>();
    }
    
    public void Push(int val) {
        if(min.Count < 1) {
            min.Add(val);
        } else if(min[min.Count-1] >= val) {
            min.Add(val);
        }
       stack.Add(val);
    }
    
    public void Pop() {
       if(stack.Count < 1) return;
       int number = stack[stack.Count-1];
       stack.RemoveAt(stack.Count-1);
       if(number == min[min.Count-1]) min.RemoveAt(min.Count-1);
    }
    
    public int Top() {
       return stack[stack.Count-1];
    }
    
    public int GetMin() {
      return min[min.Count-1];
    }
}
