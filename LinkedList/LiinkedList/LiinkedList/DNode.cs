using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiinkedList
{
    public class DNode
    {
        public int Data { get; set; }
        public DNode Prev { get; set; }
        public DNode Next { get; set; }
        public DNode()
        {

        }
        public DNode(int data)
        {
            this.Data = data;
            this.Prev = null;
            this.Next = null;
        }
    }
}
