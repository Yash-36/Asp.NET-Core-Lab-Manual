using System;

namespace Lab_1
{
    internal class Student
    {
        int EnrollmentNo, Sem;
        string StudentName;
        double CPI, SPI;
        public Student()
        {
            Console.Write("Please enter Enrollment Number : ");
            EnrollmentNo = int.Parse(Console.ReadLine());
            Console.Write("Please enter Student's Name : ");
            StudentName = Console.ReadLine();
            Console.Write("Please enter Sem : ");
            Sem = int.Parse(Console.ReadLine());
            Console.Write("Please enter CPI : ");
            CPI = double.Parse(Console.ReadLine());
            Console.Write("Please enter SPI : ");
            SPI = double.Parse(Console.ReadLine());
        }

        public void displayStudentsDetails()
        {
            Console.WriteLine("Enrollment Number : {0}", EnrollmentNo);
            Console.WriteLine("Student's Name : {0}", StudentName);
            Console.WriteLine("Sem : {0}", Sem);
            Console.WriteLine("CPI : {0}", CPI);
            Console.WriteLine("SPI : {0}", SPI);
        }
    }
}
