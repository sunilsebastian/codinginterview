using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class HeightOfNaryTree
    {

        public static NAryTreeNode Create()
        {
            NAryTreeNode tree1 = new NAryTreeNode();
            tree1.Data = 1;
            NAryTreeNode tree2 = new NAryTreeNode();
            tree2.Data = 2;
            NAryTreeNode tree3 = new NAryTreeNode();
            tree3.Data = 3;
            NAryTreeNode tree4= new NAryTreeNode();
            tree4.Data = 4;
            NAryTreeNode tree5 = new NAryTreeNode();
            tree5.Data = 5;

            tree5.children.Add(tree4);
            tree1.children.Add(tree2);
            tree1.children.Add(tree3);
            tree1.children.Add(tree5);
            return tree1;
        }
        public static int GetHeight(NAryTreeNode root)
        {
            if (root.children.Count == 0)
                return 0;

            int maxHeight = 0;
            foreach(var node in root.children)
            {
               var  height= GetHeight(node);
                if(height> maxHeight)
                {
                    maxHeight = height;
                }
            }
            return maxHeight + 1;

        }

    }
}
