public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        var queue = new Queue<int>(students);

        foreach(int s in sandwiches) {
            int n = queue.Count;
            while(n > 0 && queue.Count > 0) {
                if(queue.Peek() == s) {
                    queue.Dequeue();
                    break;
                } else {
                    queue.Enqueue(queue.Dequeue());
                    n--; 
                }
            }
            if(n <= 0) break;
        }
        return queue.Count;  
    }
}