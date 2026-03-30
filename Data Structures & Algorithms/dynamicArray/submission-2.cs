public class DynamicArray {
    private int[] arr;
    private int length;
    private int capacity;

    public DynamicArray(int capacity)
    {
        this.length = 0;
        this.capacity = capacity;
        this.arr = new int[this.capacity];
    }

    public int Get(int i) 
    {
        return arr[i];
    }

    public void Set(int i, int n) 
    {
        arr[i] = n;
    }

    public void PushBack(int n)
    {
        if(length == capacity)
        {
            Resize();
        }
        arr[length] = n;
        length++;
    }

    public int PopBack()
    {
        int lastElement = arr[length-1];
        arr[length-1] = 0;
        length--;
        return lastElement;
    }

    private void Resize() 
    {
        int nc = capacity *= 2;
        int[] newArr = new int[nc];
        this.capacity = nc; 
        for (int i = 0; i < length; i++)
        {
            newArr[i] = arr[i];
        }
        this.arr = newArr;
    }

    public int GetSize()
    {
        return this.length;
    }

    public int GetCapacity()
    {
        return this.capacity;
    }
}
