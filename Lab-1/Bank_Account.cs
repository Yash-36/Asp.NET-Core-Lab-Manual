using System;

namespace Lab_1
{
    internal class Bank_Account
    {
        int AccountNo;
        string Email, UserName, AccountType;
        double AccountBalance;
        public void GetAccountDetails()
        {
            Console.Write("Please enter Account number : ");
            AccountNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter Email : ");
            Email = Console.ReadLine();
            Console.Write("Please enter Username : ");
            UserName = Console.ReadLine();
            Console.Write("Please enter Account type : ");
            AccountType = Console.ReadLine();
            Console.Write("Please enter Account balance : ");
            AccountBalance = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account number : {0}", AccountNo);
            Console.WriteLine("Email : {0}", Email);
            Console.WriteLine("Username : {0}", UserName);
            Console.WriteLine("Account type : {0}", AccountType);
            Console.WriteLine("Account balance : {0}", AccountBalance);
        }
    }
}
