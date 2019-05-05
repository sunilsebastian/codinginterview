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
        public static  int Jump(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int lastReach = 0;
            int reach = 0;
            int step = 0;

            for (int i = 0; i <= reach && i < nums.Length; i++)
            {
                if (i > lastReach)
                {
                    step++;
                    lastReach = reach;
                }
                reach = Math.Max(reach, nums[i] + i);
            }

            if (reach < nums.Length - 1)
                return 0;

            return step;
        }


        public static  bool CanJump(int[] arr)
        {
            if (arr.Length <= 1)
                return true;

            int max = arr[0]; //max stands for the largest index that can be reached.

            for (int i = 0; i < arr.Length; i++)
            {
                //when the current position can not reach next position (return false
                if (max <= i && arr[i] == 0)
                    return false;

                //update max    
                if (i + arr[i] > max)
                {
                    max = i + arr[i];
                }

                //max is enough to reach the end
                if (max >= arr.Length - 1)
                    return true;
            }

            return false;
        }
    }
}
