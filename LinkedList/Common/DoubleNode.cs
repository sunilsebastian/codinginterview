namespace LinkedList.Common
{
    public class DoubleNode
    {
        public int Val { get; set; }

        public DoubleNode Next { get; set; }

        public DoubleNode Prev { get; set; }

        public DoubleNode(int val)
        {
            this.Val = val;
        }
    }
}