using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class StringInterLeaving
    {
        public static bool IsPerfectShuffle(string A, string B,string C)
        {
            if (A.Length + B.Length != C.Length) return false;

            bool[,] mat = new bool[A.Length + 1, B.Length + 1];

            mat[0, 0] = true;

            for(int j=1;j<=B.Length;j++)
            {
                mat[0, j] = mat[0, j - 1] && (B[j - 1] == C[j - 1]);
            }

            for (int i = 1; i <= A.Length; i++)
            {
                mat[i, 0] = mat[i-1,0] && (A[i - 1] == C[i - 1]);
            }

            for(int i=1;i<=A.Length;i++)
            {
                for (int j = 1; j <= B.Length; j++)
                {
                    mat[i, j] = (
                        (mat[i - 1, j] && (A[i - 1] == C[i + j - 1])) || (mat[i, j - 1] && (B[j - 1] == C[i + j - 1])));
                }
            }

            return  mat[A.Length,B.Length]; 
        }
    }
}
