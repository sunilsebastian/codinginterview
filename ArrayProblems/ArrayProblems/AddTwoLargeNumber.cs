using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class AddTwoLargeNumber
    {

        public static  string AddStrings(string s1, string s2)
        {
            {
                int sum = 0;
                int num1index = s1.Length - 1;
                int num2index = s2.Length - 1;

                StringBuilder result = new StringBuilder();
                while (num1index >= 0 || num2index >= 0)
                {
                    if (num1index >= 0)
                    {
                        sum += (s1[num1index] - '0');
                        num1index--;
                    }
                    if (num2index >= 0)
                    {
                        sum += (s2[num2index] - '0');
                        num2index--;
                    }

                    result.Insert(0, sum % 10);
                    //result1 = sum % 10 + result1;
                    sum = sum / 10;

                }

                return sum == 1 ? 1 + result.ToString() : result.ToString();


            }
        }

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
