using System;
using System.Collections;

namespace Lab_4
{
    internal class Program2
    {
        public void AreaMethodOverloading()
        {
            Area a = new Area();
            Console.WriteLine("Enter Length : ");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Breath : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area Of Square : " + (a.findArea(l)));
            Console.WriteLine("Area Of Reactangle : " + (a.findArea(l, b)));
        }
    }
    class Area
    {
        public double findArea(int l)
        {
            return l * l;
        }

        public double findArea(int l, int b)
        {
            return l * b;
        }
    }
}
