public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        
        Queue<int> queue = new Queue<int>(students);

        for(int i = 0; i < sandwiches.Length; i++) {

            int check = queue.Count;
            int n = queue.Count;
            while(n > 0 && queue.Peek() != sandwiches[i]) { //0-0-1-1 //0-1-0-1
                queue.Enqueue(queue.Dequeue());
                n--;
                
            }

            if(queue.Peek() == sandwiches[i]) {
                queue.Dequeue();
                
            }

            if(queue.Count == check) break;
            
        }

        return queue.Count;
    }
}