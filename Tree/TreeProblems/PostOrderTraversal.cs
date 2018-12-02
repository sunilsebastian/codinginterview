 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class PostOrderTraversal
    {
        public static void Traverse(Node root)
        {
            Stack<Node> stk = new Stack<Node>();
            Stack<Node> stk1 = new Stack<Node>();
            if (root == null)
                return;
            stk.Push(root);

            while(stk.Count!=0)
            {
                var node= stk.Pop();
                stk1.Push(node);
                if (node.Left != null)
                {
                    stk.Push(node.Left);
                }
                if(node.Right!=null)
                {
                    stk.Push(node.Right);
                }
               
            }

            while(stk1.Count!=0)
            {
                var node = stk1.Pop();
                Console.Write(node.Data + " ");
            }


        } 
    }
}
