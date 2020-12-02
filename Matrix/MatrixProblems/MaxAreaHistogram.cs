using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    public class MaxAreaHistogram
    {
        public static  int GetMaxHistogram(int[] input)
        {
            Stack<int> stack = new Stack<int>();
            int maxArea = 0;
            int area = 0;
            int i=0;
            while (i < input.Length)
            {
                if (stack.Count==0 || input[stack.Peek()] <= input[i])
                {
                    stack.Push(i++);
                }
                else
                {
                    int top = stack.Pop();
                    //if stack is empty means everything till i has to be
                    //greater or equal to input[top] so get area by
                    //input[top] * i;
                    if (stack.Count==0)
                    {
                        area = input[top] * i;
                    }
                    //if stack is not empty then everythin from i-1 to stk.peek() + 1
                    //has to be greater or equal to input[top]
                    //so area = input[top]*(i - stack.peek() - 1);
                    else
                    {
                        area = input[top] * (i - stack.Peek() - 1);
                    }
                    if (area > maxArea)
                    {
                        maxArea = area;
                    }
                }
            }
            while (stack.Count!=0)
            {
                int top = stack.Pop();
                //if stack is empty means everything till i has to be
                //greater or equal to input[top] so get area by
                //input[top] * i;
                if (stack.Count==0)
                {
                    area = input[top] * i;
                }
                //if stack is not empty then everything from i-1 to input.peek() + 1
                //has to be greater or equal to input[top]
                //so area = input[top]*(i - stack.peek() - 1);
                else
                {
                    area = input[top] * (i - stack.Peek() - 1);
                }
                if (area > maxArea)
                {
                    maxArea = area; 
                }
            }
            return maxArea;
        }
    }
}
