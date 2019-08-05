using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public class MinHeap<T>
    {
        public SortedDictionary<int, Queue<T>> map = new SortedDictionary<int, Queue<T>>();

        public void Add(int val, T node)
        {
            if (!map.ContainsKey(val))
            {
                map.Add(val, new Queue<T>());
            }

            map[val].Enqueue(node);
        }

        public T PopMin()
        {
            int minKey = map.First().Key;
            T node = map[minKey].Dequeue();

            if (map[minKey].Count == 0)
                map.Remove(minKey);

            return node;
        }

        public T Peek()
        {
            var item = map.First();
            return item.Value.Peek();
        }

        public int Count()
        {
            return map.Count();
        }
    }
}
