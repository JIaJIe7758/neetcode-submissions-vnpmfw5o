public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var stack = new Stack<int>();

        foreach(int a in asteroids) {
            if(stack.Count < 1 || a > 0) {
                stack.Push(a);
            } else {
                while(true) {
                    int peek = stack.Peek();
                    if(peek < 0) {
                        stack.Push(a);
                        break;
                    } else if(peek > -a) {
                        break;
                    }else if(peek == -a) {
                        stack.Pop();
                        break;
                    } else {
                        stack.Pop();

                        if(stack.Count == 0) {
                            stack.Push(a);
                            break;
                        }
                    }
                }
            }
        }
        return stack.Reverse().ToArray();
    }
}