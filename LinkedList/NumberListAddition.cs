using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class NumberListAddition
    {
        public static Node AddNumList(Node num1,Node num2)
        {
            Node Result = null;
            Node Start = null;
           
            int carry = 0;

            while (num1!=null || num2!=null)
            {
                int total = 0;
                if (num1!=null)
                {
                    total = total + num1.Val;
                    num1=num1.Next;
                }
                if (num2 != null)
                {
                    total = total + num2.Val;
                    num2 = num2.Next;
                }

                total += carry;
                carry = total / 10; ;
                int digit = total % 10;
                if (Result == null)
                {
                     Result = new Node(digit);
                     Start = Result;

                 }
                else
                {
                    Result.Next = new Node(digit);
                    Result = Result.Next;
                }
                
            }

            if(carry>0)
            {
                Result.Next = new Node(carry);
            }

            return Start;
        }

        private static  int GetLength(Node n)
        {
            int count = 0;
            while(n!=null)
            {
                count++;
            }
            return count;
        }

        private static Node PadZero(Node n, int padLength)
        {
            Node newNode = new Node(0);
            for(int i=0;i<padLength-2;i++)
            {
                newNode.Next = new Node(0);
            }
             newNode.Next=n;
            return newNode;
        }

        
    }
}
