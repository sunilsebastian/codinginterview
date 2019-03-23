namespace SortProblems
{
    using System.Collections.Generic;
    using System.Linq;

    public class PriorityQueue
    {
        private SortedDictionary<int, Queue<int>> dict = new SortedDictionary<int, Queue<int>>();
               
        public void Enqueue(int val, int pri)
        {
            if (!dict.ContainsKey(pri))
            {
                dict[pri] = new Queue<int>();
                dict[pri].Enqueue(val);
            }
            else
            {
                var qval = dict[pri].Peek();
                if (qval < val)
                {
                    dict[pri].Dequeue();
                    dict[pri].Enqueue(val);
                    dict[pri].Enqueue(qval);
                }
                else
                {
                    dict[pri].Enqueue(val);
                }
            }
        }

        public int Dequeue()
        {
            var item = dict.Last();
            if (item.Value.Count == 1) dict.Remove(item.Key);
            return item.Value.Dequeue();
        }

        public int Peek()
        {
            var item = dict.Last();
            return item.Value.Peek();
        }
    }
}