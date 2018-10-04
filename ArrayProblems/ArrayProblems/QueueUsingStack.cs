using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class QueueUsingStack
    {
        static Stack<int> stk1 = new Stack<int>();
        static Stack<int> stk2 = new Stack<int>();
        public static void Enqueue(int val)
        {
            stk1.Push(val);
        }

        public static int Dequeue()
        {
            if (!stk2.Any()) //if stack2 is empty push all in stk1 to stk2
            {
                while (stk1.Any())
                {
                    stk2.Push(stk1.Pop());
                }
            }
            return stk2.Any() ? stk2.Pop() : -1;
        }
    }
}
