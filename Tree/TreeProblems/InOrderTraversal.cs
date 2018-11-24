using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class InOrderTraversal
    {
        public static void Traverse(Node root)
        {
            //important in else block never add  to stack
            //this is done only in in if block.
            Stack<Node> stk = new Stack<Node>();
            while(true)
            {
                if(root!=null)
                {
                    stk.Push(root);
                    root = root.Left;
                }
                else
                {
                    if (stk.Count() == 0)
                        break;
                    root = stk.Pop();
                    Console.Write(root.Data + " ");
                    root = root.Right;
                }
            }
        }
    }
}
