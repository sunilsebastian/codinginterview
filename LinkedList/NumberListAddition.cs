﻿using LinkedList.Common;

namespace LinkedList
{
    public class NumberListAddition
    {
        public static Node AddNumList(Node num1, Node num2)
        {
            Node Result = null;
            Node Start = null;

            int carry = 0;

            while (num1 != null || num2 != null)
            {
                int total = 0;
                if (num1 != null)
                {
                    total = total + num1.Val;
                    num1 = num1.Next;
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

            if (carry > 0)
            {
                Result.Next = new Node(carry);
            }

            return Start;
        }

        public static Node AddNumListRecursion(Node num1, Node num2)
        {
            return AddNumListRecursionHelper(num1, num2, 0);
        }

        public static Node AddNumListRecursionHelper(Node num1, Node num2, int carry)
        {
            int total = 0;
            if (num1 == null && num2 == null)
            {
                if (carry > 0)
                {
                    return new Node(carry);
                }
                return null;
            }

            if (num1 != null)
            {
                total = total + num1.Val;
            }
            if (num2 != null)
            {
                total = total + num2.Val;
            }

            total += carry;
            carry = total / 10; ;
            int digit = total % 10;
            var Result = new Node(digit);
            Result.Next = AddNumListRecursionHelper(num1.Next, num2.Next, carry);

            return Result;
        }

        private static int GetLength(Node n)
        {
            int count = 0;
            while (n != null)
            {
                count++;
            }
            return count;
        }

        private static Node PadZero(Node n, int padLength)
        {
            Node newNode = new Node(0);
            for (int i = 0; i < padLength - 2; i++)
            {
                newNode.Next = new Node(0);
            }
            newNode.Next = n;
            return newNode;
        }
    }
}