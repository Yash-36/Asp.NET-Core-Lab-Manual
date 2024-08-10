using System;
using System.Collections;

namespace Lab_3
{
    internal class Program1
    {
        public void dividebyzero()
        {
            Console.WriteLine("Enter Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            try
            {
                int ans = num / 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
