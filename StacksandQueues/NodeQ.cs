using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksandQueues
{
    internal class NodeQ
    {
        public int data;
        public NodeQ next;

        public NodeQ(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
