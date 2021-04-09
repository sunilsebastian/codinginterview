namespace SortProblems
{
    //largest MinHeap
    public class KLargestElementsInStream
    {
        public static int[] TopK(int[] arr, int k)
        {
            PriorityQueue<int> pq = new PriorityQueue<int>(true);
            for (int i = 0; i < arr.Length; i++)
            {
                if (pq.Count() == k)
                {
                    if (arr[i] > pq.Peek() && !pq.map.ContainsKey(arr[i]))
                    {
                        pq.Dequeue(); //Remove Min
                        pq.Enqueue(arr[i], arr[i]); //Add
                    }
                }
                else
                {
                    if (!pq.map.ContainsKey(arr[i]))
                        pq.Enqueue(arr[i], arr[i]);
                }
            }

            int count = pq.map.Count;
            int[] result = new int[count];

            for (int j = 0; j < count; j++)
            {
                result[j] = pq.Dequeue();
            }
            return result;
        }
    }
}