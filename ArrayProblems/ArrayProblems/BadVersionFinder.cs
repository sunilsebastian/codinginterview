using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
   public  class BadVersionFinder
    {
        public static  int FirstBadVersion(int n)
        {

            return FirstBadVersionHelper(1, n);
        }

        private static int FirstBadVersionHelper(int start, int end)
        {

            //int mid = (start + end) / 2;

            if (start >= end)
                return end;

            int mid = start + (end - start) / 2;


            if (IsBadVersion(mid))
            {

                return FirstBadVersionHelper(start, mid);
            }
            else
            {
                return FirstBadVersionHelper(mid + 1, end);
            }
        }

        private static bool IsBadVersion(int mid)
        {
            return  (mid>= 126753390) ? true:false;
        }
    }
}
