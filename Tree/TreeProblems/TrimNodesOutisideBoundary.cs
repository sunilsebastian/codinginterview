﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class TrimNodesOutisideBoundary
    {
        public static  void TrimBoundary(Node root,int L, int R)
        {
            root = TrimBoundaryHelper(root, L, R);
         }
        
        private static  Node TrimBoundaryHelper(Node root,int L, int R)
        {
            if (root == null) return root;
            if (root.Data > R) return TrimBoundaryHelper(root.Left, L, R);
            if (root.Data <L) return TrimBoundaryHelper(root.Right, L, R);

            root.Left= TrimBoundaryHelper(root.Left, L, R);
            root.Right= TrimBoundaryHelper(root.Right, L, R);
            return root;
        }

    }
}