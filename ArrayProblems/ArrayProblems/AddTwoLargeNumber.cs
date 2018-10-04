using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class AddTwoLargeNumber
    {
        public static string AddTwoNumbers(string s1, string s2)
        {
            char[] num1 = s1.ToCharArray();
            char[] num2 = s2.ToCharArray();
            int sum = 0;
            int carry = 0;
            int size = (s1.Length > s2.Length) ? s1.Length + 1 : s2.Length + 1;
            char[] result = new char[size];
            int index = size - 1;
            int num1index = num1.Length - 1;
            int num2index = num2.Length - 1;


            while (true)
            {
                if (num1index >= 0 && num2index >= 0)
                {
                    sum = (num1[num1index] - '0') + (num2[num2index] - '0') + carry;
                    num1index--;
                    num2index--;
                }
                else if (num1index < 0 && num2index >= 0)
                {
                    sum = (num2[num2index] - '0') + carry;
                    num2index--;
                }
                else if (num1index >= 0 && num2index < 0)
                {
                    sum = (num1[num1index] - '0') + carry;
                    num1index--;
                }
                else { break; }


                carry = sum / 10;
                result[index] = (char)(( sum % 10) +'0');
                index--;
               
            }

            if (carry > 0)
            {
                result[index] =(char)(carry +'0');
            }
            else
            {
                result[index] = '0';
            }

        
            return new string(result);
           
        }

    }
}
