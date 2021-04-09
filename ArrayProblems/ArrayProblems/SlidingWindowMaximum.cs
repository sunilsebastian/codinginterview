using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class SlidingWindowMaximum
    {
        public static void PrintSlidingWindowMaximum1(int[] arr, int k)
        {
            int j, max;

            for (int i = 0; i <= arr.Length - k; i++)
            {

                max = arr[i];

                for (j = 1; j < k; j++)
                {
                    if (arr[i + j] > max)
                        max = arr[i + j];
                }
                Console.Write(max + " ");
            }
        }

        public static  int[] MaxSlidingWindow(int[] nums, int k) {
        
        var queue=new LinkedList<int>();
        var ans=new int[nums.Length-k+1];//len-k+1
        
        for(int i=0; i<nums.Length;i++){
                // 1 remove first item from DL  when index fall out of window size
                if (queue.Count > 0 && queue.First.Value + k  <= i)
                    queue.RemoveFirst();
                
                // 2 remove elemnets lower than current value from end
                while (queue.Count>0 && nums[queue.Last.Value]<=nums[i])
                queue.RemoveLast();
            
                // 3 add max values at end
                queue.AddLast(i);

                // 4 calculate result index and add to ans array
                //include maz of current window
                var index = i - k + 1;
                if (index >= 0)
                    ans[index] = nums[queue.First.Value];

            }
        
        return ans;
    }
    }
}
