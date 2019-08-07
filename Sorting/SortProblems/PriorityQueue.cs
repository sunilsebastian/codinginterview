using System.Collections.Generic;
using System.Linq;

namespace SortProblems
{
    public class PriorityQueue<T>
    {
        public SortedDictionary<int, Queue<T>> map;

        public int _count { get; private set; }

        public PriorityQueue(bool isMinHeap)
        {
            if (isMinHeap)
                map = new SortedDictionary<int, Queue<T>>();
            else
            {
                map = new SortedDictionary<int, Queue<T>>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            }
        }

        public void Enqueue(int val, T obj)
        {
            if (!map.ContainsKey(val))
            {
                map.Add(val, new Queue<T>());
            }

            map[val].Enqueue(obj);
            _count++;
        }

        public T Dequeue()
        {
            int minKey = map.First().Key;
            T obj = map[minKey].Dequeue();

            if (map[minKey].Count == 0)
                map.Remove(minKey);
            _count--;
            return obj;
        }

        public T Peek()
        {
            return map.Count == 0 ? default(T) : map.First().Value.Peek();
        }

        public int Count()
        {
            return _count;
        }
    }
}