using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class PreOrderArrayToTree
    {
        public Node Root { get; set; }

        public int index = 0;

        public PreOrderArrayToTree()
        {
            this.Root = null;
        }
        public void BuildTree(int[] pre, char[] preLN)
        {
            int n = pre.Length;
            this.Root = BuildTree(pre, preLN, n);

        }

        public Node BuildTree(int[] pre, char[] preLN, int n)
        {
            //if (index == n)
            //    return null;

            Node temp = new Node(pre[index++]);
            if (preLN[index - 1] == 'N')
            {
                temp.Left = BuildTree(pre, preLN, n);
                temp.Right = BuildTree(pre, preLN, n);
            }
            return temp;
        }

    }
}
