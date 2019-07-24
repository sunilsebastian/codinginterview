using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class FrogJump
    {
        public static bool CanReachLastStone(int[] stones)
        {
            Stack<int> positions = new Stack<int>();
            Stack<int> jumps = new Stack<int>();
            HashSet<int> hs = new HashSet<int>();

            for(int i=0;i<stones.Length;i++)
            {
                hs.Add(stones[i]);
            }


            int lastpostion = stones[stones.Length - 1];
            positions.Push(0);
            jumps.Push(0);
            while(positions.Count>0)
            {
                var pos = positions.Pop();
                var jumpDistance = jumps.Pop();

                for(int k= jumpDistance - 1; k<= jumpDistance + 1;k++)
                {
                    var newPos = pos + k;
                    if (newPos <= 0) continue;
                    if (newPos == lastpostion)
                        return true;

                    if(hs.Contains(newPos))
                    {
                        positions.Push(newPos);
                         jumps.Push(k);
                    }

                }
            }

            return false;


        }
    }
}
