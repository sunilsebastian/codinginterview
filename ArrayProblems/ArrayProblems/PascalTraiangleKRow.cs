using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class PascalTraiangleKRow
    {

        public static IList<int> GetRow(int rowIndex)
        {
            int[] res = new int[rowIndex + 1];

            for (int i = 0; i <= rowIndex; i++)
            {
                res[i] = 1;
                for (int j = i - 1; j > 0; j--)
                    res[j] += res[j - 1];
            }

            return res;
        }
    }
}
