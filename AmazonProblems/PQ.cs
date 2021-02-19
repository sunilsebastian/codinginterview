using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

        //Enqueue() and Dequeue() has O(log(n)) time complexity.
        //Peek hs O(1) time complexity.
        public class PQ<T> where T : IComparable<T>
        {
            private List<T> data;
            IComparer<T> _comparer;

            public PQ(bool isMinHeap = true)
            {
                this.data = new List<T>();
                if (isMinHeap)
                    _comparer = Comparer<T>.Create((a, b) => a.CompareTo(b));
                else
                    _comparer = Comparer<T>.Create((a, b) => b.CompareTo(a));

            }
            public PQ(IComparer<T> comparer)
            {
                this.data = new List<T>();
                _comparer = comparer;
            }
            public void Enqueue(T item)
            {
                data.Add(item);

                //child index is the last item
                int ci = data.Count - 1; // child index; start at end
                while (ci > 0)
                {
                    int pi = (ci - 1) / 2; // parent index
                    if (_comparer.Compare(data[ci], data[pi]) >= 0) break;
                    T tmp = data[ci];
                    data[ci] = data[pi];
                    data[pi] = tmp;
                    // what was parent index. now become child index; bubbles up
                    ci = pi;

                }
            }
            public T Dequeue()
            {
                // assumes pq is not empty; up to calling code
                int li = data.Count - 1; // last index (before removal)
                T frontItem = data[0];   // fetch the front


                data[0] = data[li];
                data.RemoveAt(li);

                //  li; // last index (after removal)
                //  int pi = 0;
                heapify(data, li, 0);

                return frontItem;
            }
            private void heapify(List<T> arr, int n, int i)
            {
                int lowest = i;  // Initialize largest as root
                int l = 2 * i + 1;  // left = 2*i + 1
                int r = 2 * i + 2;  // right = 2*i + 2

                // If left child is larger than root
                if (l < n && _comparer.Compare(arr[l], arr[lowest]) < 0)
                    lowest = l;

                // If right child is larger than largest so far
                if (r < n && _comparer.Compare(arr[r], arr[lowest]) < 0)
                    lowest = r;

                // If largest is not root
                if (lowest != i)
                {
                    T swap = arr[i];
                    arr[i] = arr[lowest];
                    arr[lowest] = swap;

                    // Recursively heapify the affected sub-tree
                    heapify(arr, n, lowest);
                }
            }
            public T Peek()
            {
                T frontItem = data[0];
                return frontItem;
            }
            public int Count()
            {
                return data.Count;
            }
        }
    }


