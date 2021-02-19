using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProblems.Common
{
    public class Node
    {
        public int Data { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(int data)
        {
            this.Data = data;
        }

        //public override string ToString()
        //{
        //    string  nodeval = this.Data.ToString();

        //    if(this.Left!=null)
        //    {
        //        nodeval= "[" + nodeval + ":" + this.Left.ToString();
        //    }
        //    else
        //    {
        //        nodeval = "[" + nodeval + ":" + "NULL";
        //    }

        //    if (this.Right != null)
        //    {
        //        nodeval = nodeval + ":" + this.Right.ToString() + "]";
        //    }
        //    else
        //    {
        //        nodeval = nodeval + ":" + "NULL" + "]";
        //    }

        //    return nodeval.ToString();
        //}
    }
}
