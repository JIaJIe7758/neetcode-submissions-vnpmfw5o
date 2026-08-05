public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        
        var queue = new Queue<int>(students);

        foreach(int s in sandwiches) {
            int n = queue.Count;
            if(queue.Count > 0) {
                while(queue.Peek() != s && n > 0) {
                    queue.Enqueue(queue.Dequeue());
                    n--;
                }

                if(n <= 0) {
                    break;
                } else {
                    queue.Dequeue();
                }
            }
        }

        return queue.Count;
    }
}