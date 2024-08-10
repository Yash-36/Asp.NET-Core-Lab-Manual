using System;

namespace Lab_1
{
    internal class Staff
    {
        String Name;
        String Department;
        String Designation;
        double Experience , Salary;

        Staff[] staff = new Staff[5];

        public void getdata()
        {
            for (int i = 0; i < staff.Length ; i++)
            {

                staff[i] = new Staff();

                Console.Write("Enter Name : ");
                staff[i].Name = Console.ReadLine();

                Console.Write("Enter Department : ");
                staff[i].Department = Console.ReadLine();

                Console.Write("Enter Designation : ");
                staff[i].Designation = Console.ReadLine();

                Console.Write("Enter Experience : ");
                staff[i].Experience = double.Parse(Console.ReadLine());

                Console.Write("Enter Salary : ");
                staff[i].Salary = double.Parse(Console.ReadLine());
            }
        }

        public void display()
        {
            for (int i = 0; i < 5; i++)
            {
                if (staff[i].Designation == "HOD")
                {
                    Console.WriteLine("Name : ",staff[i].Name);
                    Console.WriteLine("Salary : ",staff[i].Salary);
                }
                    
            }
           
        }
    }
}
