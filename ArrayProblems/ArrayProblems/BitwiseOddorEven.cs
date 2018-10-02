using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class BitwiseOddorEven
    {
        public static bool FindOdd(int n)
        {
          return  ((n & 1) ==1)?true:false;
        }
    }
}
