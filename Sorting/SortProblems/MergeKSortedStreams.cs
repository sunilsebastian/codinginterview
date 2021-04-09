using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
 
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
        PQ<(Stream, int)> pq = new PQ<(Stream, int)>(Comparer<(Stream,int)>.Create((a,b)=>a.Item2-b.Item2));
        public MergeKSortedStreams(List<List<int>> vals)
        {
            foreach (var l in vals)
            {
                var s = new Stream(l);
                var item = s.GetNext();
                if (item != -1)
                {
                    pq.Enqueue((s, item));
                }
            }
        }

        public List<int> MergeResult()
        {
            List<int> result = new List<int>();

            while (pq.Count() > 0)
            {
                var cur = pq.Dequeue();
                Stream s = cur.Item1;
                result.Add(cur.Item2);
                var item = s.GetNext();
                if (item != -1)
                {
                    pq.Enqueue((s, item));
                }

            }
            return result;
        }

    }
}
