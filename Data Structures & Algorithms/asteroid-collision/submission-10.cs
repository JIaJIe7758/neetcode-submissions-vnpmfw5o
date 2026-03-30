public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new Stack<int>();

        foreach(int i in asteroids) {
            if(stack.Count == 0 || i > 0) {
                stack.Push(i);
            } else {
                while(true) {
                    int peek = stack.Peek();
                    if(peek < 0) {
                        stack.Push(i);
                        break;
                    } else if(peek == -i) {
                        stack.Pop();
                        break;
                    } else if(peek > -i) {
                        break;
                    } else {
                        stack.Pop(); // situation where i is bigger than peek
                        if(stack.Count == 0) {
                            stack.Push(i);
                            break;
                        }
                    }
                }
            }
        }
        return stack.Reverse().ToArray();

    }
}