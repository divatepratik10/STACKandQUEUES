using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksandQueues
{
    internal class LinkedListSTACK
    {
        private Node top;

        public LinkedListSTACK()
        {
            this.top = null;
        }

        //PUSH OPERATION
        public void Push(int Val)
        {
            Node node = new Node(Val);
            if(this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;

            Console.WriteLine("{0} is Pushed into the STACK.", Val);
        }

        public void Display()
        {
            Node temp = this.top;
            while(temp != null)
            {
                Console.WriteLine("Stack Data : " +temp.data);
                temp = temp.next;
            }
        }
    }
}
