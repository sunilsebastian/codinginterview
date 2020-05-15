using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class JumpGame
    {
        //Leetcode Jump Game II
        public static int Jump(int[] nums)
        {

            int step = 0, currMaxPos = 0, nextMaxPos = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                // nextMaxPos indicates the next longest ladder to be selected
                nextMaxPos = Math.Max(nextMaxPos, i + nums[i]);

                // i == currMaxPos indicates the current longest ladder has reached the end
                if (i == currMaxPos)
                {
                    step++;
                    currMaxPos = nextMaxPos;
                }
            }

            return step;

        }
    


    public static  bool CanJump(int[] arr)
        {
            if (arr.Length <= 1) return true; ;

            int max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                max = Math.Max(max, i + arr[i]);

                if (max <= i + arr[i] && arr[i] == 0)
                {
                    return false;
                }


                if (max >= arr.Length - 1)
                    return true;
            }

            return false;

        }


        //check if you can reach to any index with value 0.
        public static bool CanReach(int[] arr, int start)
        {
            if (arr == null || arr.Length == 0) return false;
            bool[] isVisited = new bool[arr.Length];
            return canReachUtility(arr, start, isVisited);
        }

        public static bool canReachUtility(int[] arr, int index,bool[] isVisited)
        {
            if (index < 0 || index >= arr.Length || isVisited[index])
            {
                return false;
            }
            if (arr[index] == 0)
            {
                return true;
            }
            isVisited[index] = true;
            return (canReachUtility(arr, index + arr[index], isVisited) || canReachUtility(arr, index - arr[index], isVisited));
        }
    }
}

