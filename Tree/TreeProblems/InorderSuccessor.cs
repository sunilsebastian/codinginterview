﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class InorderSuccessor
    {
        public static Node GetInorderSuccessorBST(Node root, Node p)
        {
            if (root == null)
                return null;

            Node next = null;
            Node current = root;
            while (current != null && current.Data != p.Data)
            {
                
                if (current.Data > p.Data)
                {
                    //next node will be the last node we take left turn
                    next = current;
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }

            if (current == null)
                return null;

            if (current.Right == null)
                return next;
            //when the node has a right subtree, should take the minimum of the subtree which is the left most.
            current = current.Right;
            while (current.Left != null)
                current = current.Left;

            return current;
        }


        //also you can use recurive way for BT
        //left=go left 
        //set flag=true when you find target
        //if flag is true return
        //right=go right
        //if left !=null return left
        //if right!=null return right

        public static int InOrderSuccessorOfBinaryTree(Node root,int target)
        {
            bool flag = false;
            int inorderSuccessor = 0; ;
            Stack<Node> stk = new Stack<Node>();
            while (true)
            {
                if (root != null)
                {
                    stk.Push(root);
                    root = root.Left;
                }
                else
                {
                    if (stk.Count() == 0)
                        break;
                    root = stk.Pop();
                    if(flag==true)
                    {
                        inorderSuccessor= root.Data;
                        break;
                    }

                    if(root.Data==target)
                    {
                        flag = true;
                    }
                    Console.Write(root.Data + " ");
                    root = root.Right;
                }
            }
            return inorderSuccessor;
        }
    } 
}
