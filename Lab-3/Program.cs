using Lab_3;

class Program
{
    public static void Main()
    {
        int num;

        Console.WriteLine("*************************************************");

        Console.WriteLine("0. divide by zero exception");
        Console.WriteLine("1. IndexOutOfRange");
        Console.WriteLine("2. Abstract Class Sum");
        Console.WriteLine("3. InterfaceCalculate");
        Console.WriteLine("4. String Method");
        Console.WriteLine("5. lower case to Upper case");
        Console.WriteLine("6. interface Shape");
        Console.WriteLine("7. EvenNumberException");
        Console.WriteLine("8. Find longest word");
        Console.WriteLine("9. change the case");
        Console.WriteLine("10. Exit");

        Console.WriteLine("*************************************************");

        Console.WriteLine("Enter An Number : ");
        num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 0:
                Program1 p1 = new Program1();
                p1.dividebyzero();
                break;
            case 1:
                Program2 p2 = new Program2();
                p2.IndexOutOfRange();
                break;
            case 2:
                Program3 p3 = new Program3();
                p3.Sumofnum();
                break;
            case 3:
                Program4 p4 = new Program4();
                p4.interfaceCalculate();
                break;
            case 4:
                Program5 p5 = new Program5();
                p5.StringMethod();
                break;
            case 5:
                Program6 p6 = new Program6();
                p6.lowerupper();
                break;
            case 6:
                Program7 p7 = new Program7();
                p7.AreaInterface();
                break;
            case 7:
                Program8 p8 = new Program8();
                p8.UserException();
                break;
            case 8:
                Program9 p9 = new Program9();
                p9.longestworld();
                break;
            case 9:
                Program10 p10 = new Program10();
                p10.CaseChange();
                break;
            case 10:
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
}
























