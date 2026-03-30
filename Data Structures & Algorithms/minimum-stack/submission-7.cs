public class MinStack {

    private List<int> stack;
    private List<int> min;
    public MinStack()
    {
        stack = new List<int>();
        min = new List<int>();
    }
    
    public void Push(int val)
    {
        if(stack.Count == 0 && min.Count < 1) {
            min.Add(val);
        }
        else if(val <= min[min.Count-1]) {
            min.Add(val);    //-1,1,    //-1 , -1
        }
        stack.Add(val);
    }
    
    public void Pop()
    {   
        int num = stack[stack.Count-1];
        if(num == min[min.Count-1]) 
        {
            min.RemoveAt(min.Count-1);
        }
        stack.RemoveAt(stack.Count-1);
    }
    
    public int Top()
    {   
        return stack[stack.Count-1];
    }
    
    public int GetMin()
    {
       return min[min.Count-1];
    }
}
