using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksandQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO LINKED-LIST STACK PROGRAMME\n");
            LinkedListSTACK linkedListSTACK = new LinkedListSTACK();
            linkedListSTACK.Push(70);
            linkedListSTACK.Push(30);
            linkedListSTACK.Push(56);
            Console.WriteLine("\nFinal Stack list is : ");
            linkedListSTACK.Display();

            linkedListSTACK.Peek();
            Console.WriteLine("\n");
            linkedListSTACK.Pop();
            linkedListSTACK.Empty();

            Console.ReadLine();
        }
    }
}
