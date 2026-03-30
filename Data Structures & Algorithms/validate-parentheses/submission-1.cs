public class Solution {
    public bool IsValid(string s)
    {
       Stack<char> st = new Stack<char>();
       Dictionary<char,char>dict = new Dictionary<char,char>
       {
        {')','('},
        {'}','{'},
        {']','['}
       };

       foreach(char c in s)
       {
        if(dict.ContainsKey(c))
        {
            if(st.Count != 0 && st.Peek() == dict[c])
            {
                st.Pop();
            }
            else
            {
                return false;
            }
        }
        else
        {
            st.Push(c);
        }
       }
       return st.Count == 0;
    }
}
