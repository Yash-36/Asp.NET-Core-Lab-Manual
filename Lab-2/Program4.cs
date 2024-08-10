using System;
using System.Collections;

namespace Lab_2
{
    internal class Program4
    {
        public void queue_pro()
        {
            Queue q1 = new Queue();
            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);
            q1.Enqueue(4);
            q1.Enqueue(5);
            q1.Enqueue(6);

            foreach (var i in q1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("=================Dequeue===============");

            q1.Dequeue();

            foreach (var i in q1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("=================peek===============");
            Console.WriteLine(q1.Peek());

            Console.WriteLine("=================Contains===============");
            Console.WriteLine(q1.Contains(3));

            Console.WriteLine("=================Clear===============");
            q1.Clear();

            Console.ReadLine();
        }
    }
}
