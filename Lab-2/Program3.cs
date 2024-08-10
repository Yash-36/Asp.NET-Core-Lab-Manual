using System;
using System.Collections;

namespace Lab_2
{
    internal class Program3
    {
        public void stack_pro()
        {
            Stack s1 = new Stack();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            s1.Push(4);
            s1.Push(5);
            s1.Push(6);

            foreach (var i in s1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("=================pop===============");

            s1.Pop();

            foreach (var i in s1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("=================peek===============");
            Console.WriteLine(s1.Peek());

            Console.WriteLine("=================Contains===============");
            Console.WriteLine(s1.Contains(3));

            Console.WriteLine("=================Clear===============");
            s1.Clear();

            Console.ReadLine();
        }
    }
}
