public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        

        var stack = new Stack<int>();

        foreach(int a in asteroids) {
            bool destroyed = false;

            while(stack.Count > 0 && a < 0 && stack.Peek() > 0) {
                int temp = stack.Peek();
                if(a > -temp) {
                    destroyed = true;
                    break;
                } else if(a < -temp) {
                    stack.Pop();
                } else {
                    stack.Pop();
                    destroyed = true;
                    break;
                }
            }

            if(!destroyed) {
                stack.Push(a);
            }
        }

        return stack.Reverse().ToArray();
    }
}