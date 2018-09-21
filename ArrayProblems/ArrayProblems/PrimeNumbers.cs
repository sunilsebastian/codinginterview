using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class PrimeNumbers
    {
        public static void Print(int maxVal)
        {
            for(int i=2;i<maxVal;i++)
            {
                int num = i;
                int count = 0;

                while(num>=2)
                {
                    if(i%num==0)
                    {
                        count++;
                    }
                    num--;
                }
                if(count==1)
                {
                    Console.Write(i +" ");
                }
            }
        }
    }
}
