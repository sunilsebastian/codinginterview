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
            if (start > end)
                return -1;

            int mid = start + (end - start) / 2;

            var isBad = IsBadVersion(mid);
            if (isBad)
            {
                if (IsBadVersion(mid - 1) == false)
                    return mid;

                return FirstBadVersionHelper(start, mid - 1);

            }
            else
            {
                if (IsBadVersion(mid + 1) == true)
                    return mid + 1;
                return FirstBadVersionHelper(mid + 1, end);
            }
        }

        private static bool IsBadVersion(int mid)
        {
            return  (mid>= 126753390) ? true:false;
        }
    }
}
