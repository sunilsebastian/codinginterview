using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    //Boyer-Moore's algorithm
    public class MajorityVote
    {
        public static int FindMajorityElement(int[] nums)
        {
            int candidate = 0, count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    candidate = nums[i];
                    count = 1;
                }
                else if (candidate == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            if (count == 0)
                return default(int);

            count = 0;
            for(int i=0;i<nums.Length;i++)
            {
                if(nums[i]==candidate)
                {
                    count++;
                }

            }
            return (count > nums.Length / 2) ? candidate : default(int);
        }

       
    }
}
