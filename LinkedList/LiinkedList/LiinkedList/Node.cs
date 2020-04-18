﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node()
        {

        }
        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
}
