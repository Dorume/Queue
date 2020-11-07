using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Node
    {
        public int Data { get; set; }
        public Node(int number)
        {
            Data = number;
        }
        public Node Next { get; set; }
    }
}
