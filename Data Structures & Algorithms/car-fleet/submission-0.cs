public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int[][] pairs = new int[position.Length][];
        for(int i = 0; i < position.Length; i++) {
            pairs[i] = new int[]{position[i], speed[i]};
        }
        Array.Sort(pairs, (a,b) => b[0].CompareTo(a[0]));
        //(4,1) (2,2) (0,4) 96,49,26
        Stack<double> stack = new Stack<double>();
        foreach(int[] pair in pairs) {
            stack.Push((double)(target- pair[0]) / pair[1]);
            if(stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1)) {
                stack.Pop();
            }
        }
        return stack.Count;

    }
}
