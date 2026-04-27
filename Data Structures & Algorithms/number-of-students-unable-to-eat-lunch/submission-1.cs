public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        
        var queue = new Queue<int>(students);//1100 011  10 

        foreach(int s in sandwiches) {

            int n = queue.Count;
            while(n > 0 && queue.Peek() != s) {
                queue.Enqueue(queue.Dequeue());
                n--;
            }

            if(queue.Peek() == s) {
                queue.Dequeue();
                n--;
            } else {
                break;
            }

        }

        return queue.Count;
    }
}