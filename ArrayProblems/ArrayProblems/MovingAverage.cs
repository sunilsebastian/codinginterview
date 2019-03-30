using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MovingAverage
    {
        private int _windowSize;
        List<int> set = new List<int>();
        Queue<int> q = null;
        int i = 0; int j = 0;
        public MovingAverage(int windowSize)
        {
            _windowSize = windowSize;
            //for second sol
            q = new Queue<int>();
        }

        public double Next(int n)
        {
            int sum = 0;
            int count = 0;

            set.Add(n);


            for (int k = i; k <= j; k++)
            {
                sum = sum + set[k];
                count++;
            }

            j++;

            if (j >= _windowSize)
                i++;

            return sum / count;

        }

        //solution 2
        int sum1 = 0;
        public double Next1(int n)

        {
            sum1 = sum1 + n;

            q.Enqueue(n);

            if(q.Count<=3)
            {
                return sum1 / q.Count;
            }

            int r = q.Dequeue();

            sum1 = sum1 - r;

            return sum1 / _windowSize;



        }
    }
      
}
