using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    public class DNode
    {
        public int Key { get; set; }
        public int Val { get; set; }
        public DNode Prev { get; set; }
        public DNode Next { get; set; }

        public DNode(int key, int value)
        {
            this.Key = key;
            this.Val = value;
        }
    }
    public class LRUCache
    {
        Dictionary<int, DNode> dict = null;
        int cap;
        DNode head = null;
        DNode tail = null;

        public LRUCache(int capacity)
        {
            this.dict = new Dictionary<int, DNode>();
            this.cap = capacity;
        }

        public int get(int key)
        {
            if (!dict.ContainsKey(key))
            {
                return -1;
            }

            DNode t = dict[key];

            remove(t);
            setHead(t);

            return t.Val;
        }

        public void put(int key, int value)
        {
            if (dict.ContainsKey(key))
            {
                DNode t = dict[key];
                t.Val = value;

                remove(t);
                setHead(t);
            }
            else
            {
                if (dict.Count >= cap)
                {
                 dict.Remove(tail.Val);
                    remove(tail);
                }

                DNode t = new DNode(key, value);
                setHead(t);
                dict.Add(key, t);
            }
        }

        //remove a node
        private void remove(DNode t)
        {
            if (t.Prev != null)
            {
                t.Prev.Next = t.Next;
            }
            else
            {
                head = t.Next;
            }

            if (t.Next != null)
            {
                t.Next.Prev = t.Prev;
            }
            else
            {
                tail = t.Prev;
            }
        }

        //set a node to be head
        private void setHead(DNode n)
        {

            if (head == null)
            {
                head = n;
                tail = n;
            }
            else
            {
                n.Next = head;
                head.Prev = n;
                head = n;

            }


            //if (head != null)
            //{
            //    head.Prev = t;
            //}

            //t.Next = head;
            //t.Prev = null;
            //head = t;

            //if (tail == null)
            //{
            //    tail = head;
            //}
        }
    }
}
