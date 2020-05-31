using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public class Num
    {
        public int val;
        public Stream stream;
        public Num(Stream s, int val)
        {
            this.stream = s;
            this.val = val;
        }
    }
    public class Stream
    {
        IEnumerator<int> iterator;
        public Stream(List<int> list)
        {
            iterator = list.GetEnumerator();
        }

        public int GetNext()
        {
            if (iterator.MoveNext())
            {
                return iterator.Current;
            }
            return -1;
        }
    }
    public class MergeKSortedStreams
    {
        PriorityQueue<Num> pq = new PriorityQueue<Num>(true);
        public MergeKSortedStreams(List<List<int>> vals)
        {
            foreach (var l in vals)
            {
                var s = new Stream(l);
                var item = s.GetNext();
                if (item != -1)
                {
                    pq.Enqueue(item, new Num(s, item));
                }
            }
        }

        public List<int> MergeResult()
        {
            List<int> result = new List<int>();

            while (pq.map.Count > 0)
            {
                Num cur = pq.Dequeue();
                Stream s = cur.stream;
                result.Add(cur.val);
                var item = s.GetNext();
                if (item != -1)
                {
                    pq.Enqueue(item, new Num(s, item));
                }

            }
            return result;
        }

    }
}
