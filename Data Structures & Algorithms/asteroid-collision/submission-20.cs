public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        
        Stack<int> stack = new Stack<int>();

        foreach(int a in asteroids) { //10,2,-5

            bool destroyed = false; // o atual "a"

            while(stack.Count > 0 && stack.Peek() > 0 && a < 0){// unica condicao de colisao
                int top = stack.Peek();

                if(top < -a) {
                    stack.Pop();
                } else if(top == -a) {
                    stack.Pop();
                    destroyed = true;
                    break;
                } else {
                    destroyed = true;
                    break;
                }
            }
            if(!destroyed) { //if true
                stack.Push(a);
            }
        }
        return stack.Reverse().ToArray();
    }
}