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
            Console.WriteLine("Choose any one option : \n1 : STACK operations\n2 : Queue operations");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch(opt)
            {
                case 1:
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
                    break;

                case 2:
                    LinkedListQUEUE linkedListQUEUE = new LinkedListQUEUE();
                    linkedListQUEUE.Enqueue(70);
                    linkedListQUEUE.Enqueue(30);
                    linkedListQUEUE.Enqueue(56);
                    Console.WriteLine("Final Queue list is : ");
                    linkedListQUEUE.DisplayQ();
                    break;
            }
           

            Console.ReadLine();
        }
    }
}
