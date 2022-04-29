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

        //DEQUEUE
        public void Dequeue()
        {
            if(this.head == null)
            {
                Console.WriteLine("Queue is EMPTY.");
                return;
            }

            int DeleteNode = this.head.data;
            this.head = this.head.next;
            Console.WriteLine("{0} is DELETED from the QUEUE.",DeleteNode);
        }

        //DISPLAY
        public void DisplayQ()
        {
            NodeQ temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Queue is EMPTY.");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine("Queue Data : " + temp.data);
                    temp = temp.next;
                }
            }

            
        }

    }
}
