using System;

namespace Lab_1
{
    class Account_Details
    {
        public int AccountNo;
        public string UserName;
        public double Principle, RateOfInerest, TimePeriod;
        public void GetAccountDetails()
        {
            Console.Write("Please enter Account No : ");
            AccountNo = int.Parse(Console.ReadLine());
            Console.Write("Please enter Username : ");
            UserName = Console.ReadLine();
            Console.Write("Please enter Principle : ");
            Principle = double.Parse(Console.ReadLine());
            Console.Write("Please enter Rate : ");
            RateOfInerest = double.Parse(Console.ReadLine());
            Console.Write("Please enter Time : ");
            TimePeriod = double.Parse(Console.ReadLine());
        }
    }

    class Interest : Account_Details
    {
        public Interest()
        {
            GetAccountDetails();
        }
        public void DisplayInterest()
        {
            Console.WriteLine("Simple Interest: {0}", ((Principle * RateOfInerest *TimePeriod) / 100));
        }
    }
}
