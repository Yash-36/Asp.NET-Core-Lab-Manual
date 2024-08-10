using System;
using System.Collections;
delegate int Factorial(int n);

namespace Lab_4
{
    internal class Program4
    {
        public void df()
        {
            Factorial f = new Factorial(calculateFactorial);

            Console.Write("Enter Number : ");
            int n = Convert.ToInt32((Console.ReadLine()));

            int answer = f(n);
            Console.WriteLine("Factorial : " + answer);
        }
        public int calculateFactorial(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
