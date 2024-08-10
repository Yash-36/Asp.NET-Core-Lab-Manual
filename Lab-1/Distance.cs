using System;

namespace Lab_1
{
    internal class Distance
    {
        double dist1, dist2, dist3;
        public Distance(double dist1, double dist2)
        {
            this.dist1 = dist1;
            this.dist2 = dist2;
        }
        public void Sum()
        {
            this.dist3 = this.dist1 + this.dist2;
        }
        public void Display()
        {
            Console.WriteLine("Answer : {0}", this.dist3);
        }
    }
}
