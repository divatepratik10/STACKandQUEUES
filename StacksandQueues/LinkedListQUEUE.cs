using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksandQueues
{
    internal class LinkedListQUEUE
    {
        private NodeQ head;

        //ENQUEUE
        public void Enqueue(int value)
        {
            NodeQ newnode = new NodeQ(value);
            if(this.head == null)
            {
                this.head = newnode;
            }
            else
            {
                NodeQ temp = this.head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
            }
            Console.WriteLine("{0} is Inserted into the Queue.",value);
        }
        //DISPLAY
        public void DisplayQ()
        {
            NodeQ temp = this.head;
            while (temp != null)
            {
                Console.WriteLine("Queue Data : " + temp.data);
                temp = temp.next;
            }
        }

    }
}
