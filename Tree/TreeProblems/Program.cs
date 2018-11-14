using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Insert to a binary Tree
            BST bst = new BST();
            bst.Insert(20);
            bst.Insert(10);
            bst.Insert(8);
            bst.Insert(15);
            Console.WriteLine(bst.Root.ToString());

            //Remove minimum

            Console.ReadLine();

        }
    }
}
