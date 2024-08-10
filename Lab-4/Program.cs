using Lab_4;

class Program
{
    public static void Main()
    {
        int num;

        Console.WriteLine("*************************************************");

        Console.WriteLine("0. SumMethodOverloading");
        Console.WriteLine("1. AreaMethodOverloading");
        Console.WriteLine("2. CalculateInterest");
        Console.WriteLine("3. Delagate Factorial");
        Console.WriteLine("4. HospitalMethodOverloading");
        Console.WriteLine("5. AreasMethodOverloading");
        Console.WriteLine("6. TrafficSignal");
        Console.WriteLine("7. delegate calculator");
        Console.WriteLine("8. Exist");

        Console.WriteLine("*************************************************");

        Console.WriteLine("Enter An Number : ");
        num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 0:
                Program1 p1 = new Program1();
                p1.SumMethodOverloading();
                break;
            case 1:
                Program2 p2 = new Program2();
                p2.AreaMethodOverloading();
                break;
            case 2:
                Program3 p3 = new Program3();
                p3.CalculateInterest();
                break;
            case 3:
                Program4 p4 = new Program4();
                p4.df();
                break;
            case 4:
                Program5 p5 = new Program5();
                p5.HospitalMethodOverloading();
                break;
            case 5:
                Program6 p6 = new Program6();
                p6.AreasMethodOverloading();
                break;
            case 6:
                TrafficSignal t = new TrafficSignal();
                t.dt();
                break;
            case 7:
                Program8 p8 = new Program8();
                p8.dc();
                break;
            case 8:
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
}