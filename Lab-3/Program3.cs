using System;
using System.Collections;

namespace Lab_3
{
    internal class Program3
    {
        public void Sumofnum()
        {
            A1 r = new A1();
            Console.WriteLine("Enter First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum Of " + num1 + " and " + num2 + " is " + r.sumOfTwo(num1, num2));
            Console.WriteLine("Enter Third Number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum Of " + num1 + "," + num2 + " and " + num3 + " is " + r.sumOfThree(num1, num2, num3));

        }
    }
    abstract class Sum
    {
        public abstract int sumOfTwo(int a, int b);
        public abstract int sumOfThree(int a, int b, int c);
    }
    class A1 : Sum
    {
        public override int sumOfTwo(int a, int b)
        {
            return a + b;
        }

        public override int sumOfThree(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
