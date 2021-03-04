using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class RobotReturnToOrgin
    {
        //Time complexity O(N)
        //Space complexity O(1)


        //1041. Robot Bounded In Circle

        //GGLLGG
        //GG
        //GL
        public static bool isRobotBounded(String instructions)
        {
            // north = 0, east = 1, south = 2, west = 3
            int[][] directions = new int[4][] { new int[]{ 0, 1 }, 
                                                new int[]{ 1, 0 }, 
                                                new int[]{ 0, -1 }, 
                                                new int[]{ -1, 0 } };
            // Initial position is in the center
            int x = 0, y = 0;
            // facing north
            int dir = 0;

            foreach (var i in  instructions.ToCharArray())
            {
                if (i == 'L')
                    dir = (dir + 3) % 4;
                else if (i == 'R')
                    dir = (dir + 1) % 4;
                else
                {
                    x += directions[dir][0];
                    y += directions[dir][1];
                }
            }

            // after one cycle:
            // robot returns into initial position
            // or robot doesn't face north
            return (x == 0 && y == 0) || (dir != 0);
        }


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

        public static int roverMove(String[] cmnds, int n)
        {
            //0  1  2   3
            //4  5  6   7
            //8  9  10  11
            //12 13 14  15


            int row = 0;
            int col = 0;
            foreach (var  cmnd in cmnds)
            {
                if (cmnd == "RIGHT")
                {
                    if (col < n - 1) col = col + 1;
                }
                else if (cmnd == "LEFT")
                {
                    if (col > 0) col = col - 1;
                }
                else if (cmnd == "UP")
                {
                    if (row > 0) row = row - 1;
                }
                else
                {
                    if (row < n - 1) row = row + 1;
                }
            }
            return (row * n) + col;
        }


        //UU LL RR DD  LDRRLRUULR
        //public bool JudgeCircle(string moves)
        //{

        //    int x = 0, y = 0;
        //    foreach (var move in moves.ToCharArray())
        //    {
        //        if (move == 'U') y++;
        //        else if (move == 'D') y--;
        //        else if (move == 'L') x--;
        //        else if (move == 'R') x++;
        //    }
        //    return x == 0 && y == 0;

        //}

    }
}
