using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{

//numCustomers = 4

//arrTime = [0, 0, 1,5]

//direction = [0, 1, 1, 0]

//Output: [2,0,1,5]
//Explanation:
//At time 0, customer 0 and 1 want to pass through the turnstile.Customer 0 wants to enter the store and customer 1 wants to exit the store.The turnstile was not used in the previous second, so the priority is on the side of the customer 1
//At time 1, customers 0 and 2 want to pass through the turnstile. Customer 2 wants to exit the store and at the previous second the turnstile was used as an exit, so the customer `2 passes through the turnstile.
//At time 2, customer 0 passes through the turnstile.
//At time 5, customer 3 passes through the turnstile.
    public class Turnstile
    {

        public static int[] GetTimes(int numCustomers, int[] arrTime, int[] direction)
        {
            //store the time each user(index) get opertunity to Eter/Exit.
            int[] result = new int[arrTime.Length];

            Queue<(int, int)> enter= new Queue<(int, int)>();

            Queue<(int, int)> exit = new Queue<(int, int)>();

            for (int i = 0; i < arrTime.Length; i++)
            {
                int tme = arrTime[i], dir = direction[i];
                if (dir == 1)
                {
                exit.Enqueue((tme, i));
                }
                else
                {
                enter.Enqueue((tme, i ));
                }
            }
            //no body entered or exit. no previous state
            int prev = 1;

            //At first time=0;
            int time = 0;

            while (enter.Count()!=0 || exit.Count()!=0) {
                bool hasIn = (enter.Count() != 0 )&& enter.Peek().Item1 <= time;
                bool hasOut = (exit.Count() != 0) && exit.Peek().Item1 <= time;
                if (hasIn && hasOut)
                {
                    if (prev == 1)
                        result[exit.Dequeue().Item2] = time;
                    else
                        result[enter.Dequeue().Item2] = time;
                }

                else if (hasIn)
                {
                    result[enter.Dequeue().Item2] = time;
                    prev = 0;
                }
                else if (hasOut)
                {
                    result[exit.Dequeue().Item2] = time;
                    prev = 1;
                }
                //no body there in que at this particular time. nobody there/prev exit considered as 1
                else
                {
                    prev = 1;
                }
                time++;
            }
            return result;
        }


        }
}
