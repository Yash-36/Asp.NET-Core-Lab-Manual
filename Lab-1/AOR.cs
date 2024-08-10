using System;

namespace Lab_1
{
    internal class AOR
    {
        double length, breadth;
        public AOR(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public double CalculateArea()
        {
            return this.length * this.breadth;
        }

    }
}
