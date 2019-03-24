using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MovingAverage
    {
        private   int _windowSize;
        List<int> set = new List<int>();
        int i = 0; int j = 0;
        public MovingAverage(int windowSize)
        {
            _windowSize = windowSize;
        }

        public double Next(int n)
        {
            int sum = 0;
            int count = 0;

            set.Add(n);
           

            for(int k=i;k<=j;k++)
            {
                sum = sum + set[k];
                count++;
            }

            j++;

            if (j>=_windowSize)
                i++;

            return sum / count;


        }

    }
}
