using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class ConvertToExcelTitle
    {

        //A->65->mapped to 0
        //Z->90 ie mapped to 25

        //AB is 28 //AA is 27

        // 0 * 26 + ('A'-65 +1)  => 0*26 +1=1
        //1 *26 +('B'-65 +1)= 26+ 1+1=28

        public int titleToNumber1(String s)
        {
            int result = 0;
            int n = s.Length;
            for (int i = 0; i < n; i++)
            {
                result = result * 26;
                result += (s[i] - 'A' + 1);
            }
            return result;
        }


        // 28  
        // n-1 is 27  because 
        // 27%26=1
        // 65 +1=66 ==>B
        // n==1
        //n-1 is 0
        //0%26=0
        //65+0=65=> A
        public String convertToTitle(int n)
        {
            StringBuilder res = new StringBuilder();
            while (n > 0)
            {
                n--;
                res.Insert(0, (char)(65+ n % 26));
                n /= 26;
            }
            return res.ToString();
        }
    }
}
