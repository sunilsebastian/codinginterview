using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class TransformArrayValue
    {
        public static int[] Convert(int[] input)
        {
        
            int[] front = new int[input.Length];
            int[] rear = new int[input.Length];
            int[] output=new int[input.Length];


            front[0] = 1;
            rear[input.Length - 1] = 1;

            for (int i = 1; i < input.Length; i++)
            {
                front[i] = front[i - 1] * input[i - 1];

            }

            for (int j = input.Length - 2; j >= 0; j--)
            {
                rear[j] = rear[j + 1] * input[j + 1];
            }

            for (int i = 0; i < input.Length; i++)
            {
                output[i] = front[i] * rear[i];
            }

            return output;
        }
    }
}
