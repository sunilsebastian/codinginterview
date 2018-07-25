using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CheckListIsCircular
    {
        //10-->20-->30-->40-->50
        public static bool Check(Node head)
        {
            bool isCircular = false;
            Node current = head;
            while(current!=null)
            {
                current = current.Next;
                if (current == head)
                {
                    isCircular = true;
                    break;
                }
            }
            return isCircular;
        }
    }
}
