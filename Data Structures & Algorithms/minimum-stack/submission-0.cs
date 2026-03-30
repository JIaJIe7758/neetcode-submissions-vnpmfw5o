public class MinStack {

    private List<int> stack;
    public MinStack()
    {
        stack = new List<int>();
    }
    
    public void Push(int val)
    {
        stack.Add(val);
    }
    
    public void Pop()
    {
        if(stack.Count != 0)
        {
            stack.RemoveAt(stack.Count-1);
        }
        
    }
    
    public int Top()
    {
        return stack[stack.Count-1];
    }
    
    public int GetMin()
    {
        int min = stack[0];
        foreach(int i in stack)
        {
            if(i < min) min = i;
        }
        return min;
    }
}
