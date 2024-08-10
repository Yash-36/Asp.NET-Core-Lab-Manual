using System;
using System.Collections;

namespace Lab_2
{
    internal class Program2
    {
        public void list()
        {
            List<string> a1 = new List<string>();
            a1.Add("Yash");
            a1.Add("Mohit");
            a1.Add("Mudit");
            a1.Add("Jay");

            Console.WriteLine("===============Add===================");
            foreach (var i in a1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("==================Remove=========================");

            a1.Remove("Mudit");

            foreach (var i in a1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("==================RemoveRange=========================");

            a1.RemoveRange(1, 2);

            foreach (var i in a1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("======================Clear=======================");
            a1.Clear();

            foreach (var i in a1)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
