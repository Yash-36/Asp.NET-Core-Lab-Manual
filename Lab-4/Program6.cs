using System;
using System.Collections;

namespace Lab_4
{
    internal class Program6
    {
        public void AreasMethodOverloading ()
        {
            Areas a = new Areas();
            Console.WriteLine("Enter Length : ");
            double l = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Breath : ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Radius : ");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area Of Square : " + (a.findAreas(l)));
            Console.WriteLine("Area Of Reactangle : " + (a.findAreas(l, b)));
            Console.WriteLine("Area Of Circle : " + (a.findAreas(r)));
        }
    }

    class Areas
    {
        public double findAreas(double l)
        {
            return l * l;
        }

        public double findAreas(double l, double b)
        {
            return l * b;
        }

        public double findAreas(int r)
        {
            return Math.PI * r * r;
        }
    }
}
