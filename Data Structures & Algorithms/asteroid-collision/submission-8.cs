public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new Stack<int>();

        for(int i = 0; i < asteroids.Length; i++) {
            if(stack.Count == 0 || asteroids[i] > 0) {
                stack.Push(asteroids[i]);
            } else {
                while(true) {
                    int peek = stack.Peek();
                    if(peek < 0) {
                        stack.Push(asteroids[i]);
                        break;
                    } else if(peek == -asteroids[i]) {
                        stack.Pop();
                        break;
                    } else if(peek > -asteroids[i]) {
                        break;
                    } else {
                        stack.Pop();
                        if(stack.Count == 0) {
                            stack.Push(asteroids[i]);
                            break;
                        }
                    }
                }
            }
        }
        return stack.Reverse().ToArray();
    }
}