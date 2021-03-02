﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A risk modeling system uses a scaling computing system that implements an autoscale policy depending on the current load or utilization the computing system.

//The system starts with a number of computing instances given by instances.The system polls the instances every second to see the average utilization at that second, and performs scaling as given below. Once any action is taken, the system will stop polling for 10 seconds.During that time, the number of instances does not change.

//Average utilization > 60%: Double the number of instances if the doubled value does not exceed 2 * 10^8. This is an action. If the number of instances exceeds this limit on doubling, perform no action.

//Average utilization < 25%: Halve the number of instances if the number of instances is greater than 1 (take ceil if the number is not an integer). This is also an action.If the number of instances is 1, take no action.

//25% <= Average utilization <= 60%: No action

//Given the values of the average utilization at each second for this system as an array determine the number of instances at the end of the time frame.

//For example, the system starts with instances = 2.Average utilization is given as averageUtil = [25, 23, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 76, 80].

//At the first second, utilization is 25, so no action is taken.

//At the second second, averageUtil[0] = 23 < 25, so instances = 2 / 2 = 1.The next 10 seconds, averageUtil[1]..averageUtil[10], no polling is done.

//At averageUtil[11] = 76, 76 > 60 so the number of instances is doubled.There are no more readings to consider and 2 is the final answer.


namespace AmazonProblems
{
    public class UtilizationChecks
    {
        public static int finalInstances(int instances, int[] averageUtil)
        {
            int skip = 0;
            foreach(int avg in averageUtil)
            {
                if (skip > 0)
                {
                    skip--;
                }
                else
                {
                    int newInstance = instances;
                    if (avg < 25)
                    {
                        //one instance no action
                        if (instances == 1) continue;
                        
                        //divide and    Math.Ceiling
                        newInstance = (instances / 2) + (instances % 2);
                    }
                    else if (avg > 60)
                    {
                        long doubled = instances * 2L;
                        newInstance = doubled > 2_0000_0000 ? instances : 2 * instances;
                    }
                    //if there is a change in new instance skip 10 cycles
                    if (newInstance != instances)
                    {
                        instances = newInstance;
                        skip = 10;
                    }
                }
            }
            return instances;
        }


    }
}
