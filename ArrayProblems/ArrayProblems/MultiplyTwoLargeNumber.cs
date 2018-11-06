using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MultiplyTwoLargeNumber
    {
        public static string MultiplyBigNumbers(string s1, string s2)
        {
            char[] num1 = s1.ToCharArray();
            char[] num2 = s2.ToCharArray();
            //string=99
            //char--> 9 , val --> 57(48+9) 
            //so s[i]-'0' will give val 9 and char as horizontal tab

            char[] result = new char[num1.Length + num2.Length]; // Default 0 '/0'  2 ==> 50 '2'
            int carry = 0;
            int offset = 0;

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int tail = result.Length - 1 - offset;
                for (int j = num2.Length - 1; j >= 0; j--)
                {
                    int resval = 0;
                    if(result[tail]!=0)
                    {
                        resval = result[tail] - '0';
                    }
                    int sum =  resval+ ((num1[i] - '0') * (num2[j] - '0')) + carry; //remember to add result before taking mode 
                    result[tail] = (char)((sum % 10) + '0');
                    carry = sum / 10;
                    tail--;
                }
                if (carry > 0)
                {
                    int res = (result[tail] != 0) ? (result[tail] - '0') + carry : result[tail] + carry;

                    result[tail] = (char)(res + '0');
                    carry = 0;
                }
                offset++;
            }

            return new string(result);
        }

        
    }
}
