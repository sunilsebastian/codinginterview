using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MajorityVote
    {
        public static int FindMajorityElement(int[] nums)
        {
            int result = 0, count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    result = nums[i];
                    count = 1;
                }
                else if (result == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            int cnt = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(result==nums[i])
                {
                    cnt++;
                }
            }

            return (cnt>(nums.Length/2))?result:-1;
        }
    }
}
