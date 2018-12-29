using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblems.Common
{
    public class DisJointSets
    {

        public void MakeSet(Subset[] subsets)
        {
            for (int i = 0; i < subsets.Length; i++)
            {
                subsets[i] = new Subset();
                subsets[i].Parent = i;
                subsets[i].Rank = 0;

            }
        }

        public int FindSet(Subset[] subsets,int i)
        {
            if (subsets[i].Parent != i)
                subsets[i].Parent= FindSet(subsets, subsets[i].Parent);

            return subsets[i].Parent;
        }

        public void Union(Subset[] subsets,int x, int y)
        {
            int xpos = FindSet(subsets,x);
            int ypos = FindSet(subsets,y);

            if(subsets[xpos].Rank> subsets[ypos].Rank)
            {
                subsets[ypos].Parent = xpos;
            }
            else if (subsets[xpos].Rank <subsets[ypos].Rank)
            {
                subsets[xpos].Parent = ypos;
            }
            else
            {
                subsets[xpos].Parent = ypos;
                subsets[ypos].Rank++;

            }
        }


    }
}
