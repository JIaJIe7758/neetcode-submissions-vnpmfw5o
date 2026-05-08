public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        
        var stack = new Stack<int>();

        foreach(int a in asteroids) {
            bool destroyed = false;

            while(stack.Count > 0 && stack.Peek() > 0 && a < 0) {

                if(stack.Peek() < -a) {
                    stack.Pop();
                } else if(stack.Peek() == -a) {
                    stack.Pop();
                    destroyed = true;
                    break;
                } else {
                    destroyed = true;
                    break;
                }
            }
            if(destroyed == false) {
                stack.Push(a);
            }
        }

        return stack.Reverse().ToArray();
    }
}