using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public  class OptimizeMemoryUsage
    {

        public static int[][] findPairs(int[] foregroundTasks, int[] backgroundTasks, int K)
        {
            List<int[]> result = new List<int[]>();
            if (K == 0 || (foregroundTasks.Length == 0 && backgroundTasks.Length == 0))
                result.Add(new int[] { -1, -1 });
            int i;
            List<int[]> foregroundTaskList = new List<int[]>();
            List<int[]> backgroundTaskList = new List<int[]>();

            for (i = 0; i < foregroundTasks.Length; i++)
            {
                foregroundTaskList.Add(new int[] { i, foregroundTasks[i] });
            }

            for ( i = 0; i < backgroundTasks.Length; i++)
            {
                backgroundTaskList.Add(new int[] { i, backgroundTasks[i] });
            }

            if(foregroundTaskList.Count>1)
                    foregroundTaskList.Sort((p1, p2)=>p1[1] - p2[1]);
            if (backgroundTaskList.Count>1)
                    backgroundTaskList.Sort((p1, p2)=>p1[1] - p2[1]);

            int max = Int32.MinValue;

            //already target from one list ther list value will be -1
            for ( i = 0; i < foregroundTasks.Length; i++)
            {
                if (foregroundTaskList[i][1] == K)
                {
                    result.Add(new int[] { foregroundTaskList[i][0], -1 });
                    max = foregroundTaskList[i][1];
                }
            }
            //already target from one list ther list value will be -1
            for ( i = backgroundTasks.Length - 1; i >= 0; i--)
            {
                if (backgroundTaskList[i][1] == K)
                {
                    result.Add(new int[] { -1, backgroundTaskList[i][0] });
                    max = backgroundTaskList[i][1];
                }
            }

            //other array is empty
            if (foregroundTasks.Length > 0 && backgroundTasks.Length == 0)
            {
                for ( i = 0; i < foregroundTasks.Length; i++)
                {
                    if (foregroundTaskList[i][1] < K)
                    {
                        result.Add(new int[] { foregroundTaskList[i][0], -1 });
                    }
                }

                return result.ToArray();
            }

            //other array is empty
            if (backgroundTasks.Length > 0 && foregroundTasks.Length == 0)
            {
                for ( i = backgroundTasks.Length - 1; i >= 0; i--)
                {
                    if (backgroundTaskList[i][1] < K)
                    {
                        result.Add(new int[] { -1, backgroundTaskList[i][0] });
                    }
                }

                return result.ToArray();
            }

            //------------------Same as optimal utilization---------------------------------
             i = 0;
            int j = backgroundTasks.Length - 1;

            while (i < foregroundTasks.Length && j >= 0)
            {
                int sum = foregroundTaskList[i][1] + backgroundTaskList[j][1];
                if (sum > K)
                {
                    --j;
                }
                else
                {
                    if (max <= sum)
                    {
                        if (max < sum)
                        {
                            max = sum;
                            result.Clear();
                        }
                        result.Add(new int[] { foregroundTaskList[i][0], backgroundTaskList[j][0] });
                        int index = j - 1;
                        while (index >= 0 && backgroundTaskList[index][1] == backgroundTaskList[index + 1][1])
                        {
                            result.Add(new int[] { foregroundTaskList[i][0], backgroundTaskList[index][0] });
                            index--;
                        }
                    }
                    ++i;
                }
            }
            return result.ToArray();

        }
    }
}
