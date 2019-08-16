using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public class BSTCount
    {
        private static Dictionary<int, int> dict;
        public static int PrintBST(int n)
        {
            dict = new Dictionary<int, int>();
            int result=  PrintBSTHelper(n);
            return result;
        }

        public static int PrintBSTHelper(int n)
        {
            int sum = 0;

            if(n==0||n==1)
            {
                return 1;
            }

            for(int i=0;i<n;i++)
            {
                if(!dict.ContainsKey(i))
                {
                    dict.Add(i, PrintBSTHelper(i));
                }
                if (!dict.ContainsKey(n - i - 1))
                {
                    dict.Add(n - i - 1, PrintBSTHelper(n - i - 1));
                }
                sum += dict[i] * dict[n - i - 1];
            }

            return sum;

        }
    }
}
