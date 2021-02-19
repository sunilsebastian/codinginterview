using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class RobotReturnToOrgin
    {
        public bool IsRobotBounded(string instructions)
        {
            int N = 0;
            int E = 1;
            int S = 2;
            int W = 3;
            // R move from West has to go N  (dir+1)%4
            //Left move from N should go West (4+(dir-1))%4

            int x = 0;
            int y = 0;

            int dir = N;

            for (int i = 0; i < instructions.Length; i++)
            {
                if (instructions[i] == 'R')
                    dir = (dir + 1) % 4;
                else if (instructions[i] == 'L')
                    dir = (4 + (dir - 1)) % 4;
                else if (instructions[i] == 'G')
                {
                    if (dir == N)
                        y++;
                    else if (dir == E)
                        x++;
                    else if (dir == S)
                        y--;
                    else if (dir == W)
                        x--;

                }
            }

            if ((x == 0 && y == 0) || dir != N)
                return true;

            return false;
        }

    }
}
