using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProblems
{
    //i=0, count[0]=1 //empty tree
    //i=1, count[1]=1 //one tree

    //i=2, count[2]=count[0]* count[1] 
    //            + count[1]* count[0] 

    //i=3, count[3]=count[0]* count[2] 
    //            + count[1]* count[1] 
    //            + count[2]* count[0]

    //i=4, count[4]=count[0]* count[3]
    //            + count[1]* count[2]
    //            + count[2]* count[1]
    //            + count[3]* count[0]


   //another solution 2n!/(n+1)! n!   will give the number

    public class UniqueBSTCount
    {


        public static int  Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n-1);
        }
            public static int GetUniqueBSTCount(int n)
        {
            int[] bstCountArray = new int[n + 1];

            bstCountArray[0] = 1;

            bstCountArray[1] = 1;

            // As 
            for ( int i=2;i<=n;i++)
            {
                for(int j=0;j<i;i++)
                {
                    bstCountArray[i] = bstCountArray[i] + (bstCountArray[j] * bstCountArray[i - j - 1]);
                }
            }
            return bstCountArray[n];
        }
    }
}
