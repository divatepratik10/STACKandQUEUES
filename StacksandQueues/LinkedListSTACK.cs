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
        
        //POP
        public void Pop()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is EMPTY.\nDeletation is not Possible.");
                return;
            }
            Console.WriteLine("Pooped Value : {0}", this.top.data);
            this.top = this.top.next;
        }
        //PEEK
        public void Peek()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is EMPTY.");
            }
            Console.WriteLine("{0} is at the top of Stack.",this.top.data);
        }
        //EMPTY
        public void Empty()
        {
            while(this.top != null)
            {
                Peek();
                Pop();
            }
        }
        //DISPLAY
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine("Stack Data : " + temp.data);
                temp = temp.next;
            }
        }

    }
}
