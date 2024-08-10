using Lab_1;

class Program
{
    public static void Main()
    {
        int num;

        Console.WriteLine("*************************************************");

        Console.WriteLine("0. Candidate Details");
        Console.WriteLine("1. Staff Details");
        Console.WriteLine("2. Bank_Account");
        Console.WriteLine("3. Student Details");
        Console.WriteLine("4. Area of a Rectangle");
        Console.WriteLine("5. Account_Details");
        Console.WriteLine("6. Salary Details");
        Console.WriteLine("7. Distance Details");
        Console.WriteLine("8. Furniture Details");
        Console.WriteLine("9. Employee Details");
        Console.WriteLine("10. Exist");

        Console.WriteLine("*************************************************");

        Console.WriteLine("Enter An Number : ");
        num = int.Parse(Console.ReadLine());

        Console.WriteLine("\n");

        switch (num)
        {
            case 0:
                Candidate c = new Candidate();
                c.GetCandidateDetails();
                Console.WriteLine("\n----------Candidate Details-----------\n");
                c.DiplayCandidateDetails();
                break;
            case 1:
                Staff s1 = new Staff();
                s1.getdata();
                Console.WriteLine("\n----------Staff details--------------\n");
                s1.display();
                break;
            case 2:
                Bank_Account bankAccount = new Bank_Account();
                bankAccount.GetAccountDetails();
                Console.WriteLine("\n----------Bank details--------------\n");
                bankAccount.DisplayAccountDetails();
                break;
            case 3:
                Student st = new Student();
                Console.WriteLine("\n-----------Student details------------\n");
                st.displayStudentsDetails();
                break;
            case 4:
                Console.Write("Enter length : ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter breadth : ");
                double breadth = double.Parse(Console.ReadLine());
                AOR a1 = new AOR(length, breadth);
                Console.WriteLine("\n-----------Area of Rectriangle------------\n");
                Console.WriteLine("Area of Rectangel is : " + a1.CalculateArea().ToString());
                break;
            case 5:
                Interest i = new Interest();
                Console.WriteLine("\n-----------Simple Interest------------\n");
                i.DisplayInterest();
                break;
            case 6:
                Salary salary = new Salary();
                Console.WriteLine("\n-----------Salary details------------\n");
                salary.Display();
                break;
            case 7:
                Console.Write("Please enter distance 1 : ");
                double dist1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter distance 2 : ");
                double dist2 = Convert.ToDouble(Console.ReadLine());
                Distance d = new Distance(dist1, dist2);
                d.Sum();
                Console.WriteLine("\n-----------Distance details------------\n");
                d.Display();
                break;
            case 8:
                Table objTable = new Table();
                objTable.GetData();
                Console.WriteLine("\n-----------Table details------------\n");
                objTable.ShowData();
                break;
            case 9:
                Salary1 s = new Salary1();
                Console.WriteLine("\n-----------Salary details------------\n");
                s.Display_Salary();
                break;
            case 10:
                break;
            default:
                Console.WriteLine("Invalid Number");
                break;
        }
    }
}