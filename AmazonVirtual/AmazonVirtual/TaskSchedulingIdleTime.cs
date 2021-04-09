using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonVirtual
{
    public class TaskSchedulingIdleTime
    {
        public static int leastInterval(char[] tasks, int n)
        {
            // frequencies of the tasks
            int[] frequencies = new int[26];
            foreach (int t in tasks)
            {
                frequencies[t - 'A']++;
            }

            Array.Sort(frequencies);

            // max frequency
            int f_max = frequencies[25];
            int idle_time = (f_max - 1) * n;

            for (int i = frequencies.Length - 2; i >= 0 && idle_time > 0; --i)
            {
                idle_time -= Math.Min(f_max - 1, frequencies[i]);
            }
            idle_time = Math.Max(0, idle_time);

            return idle_time + tasks.Length;
        }
    }
}
