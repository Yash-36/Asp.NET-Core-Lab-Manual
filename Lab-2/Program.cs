using Lab_2;
class Program
{
    public static void Main()
    {
        int num;

        Console.WriteLine("*************************************************");

        Console.WriteLine("0. ArrayList");
        Console.WriteLine("1. List");
        Console.WriteLine("2. Stack");
        Console.WriteLine("3. Queue");
        Console.WriteLine("4. Exist");

        Console.WriteLine("*************************************************");

        Console.WriteLine("Enter An Number : ");
        num = int.Parse(Console.ReadLine());

        Console.WriteLine("\n");

        switch (num)
        {
            case 0:
                Program1 p1 = new Program1();
                p1.a_List();
                break;
            case 1:
                Program2 p2 = new Program2();
                p2.list();
                break;
            case 2:
                Program3 p3 = new Program3();
                p3.stack_pro();
                break;
            case 3:
                Program4 p4 = new Program4();
                p4.queue_pro();
                break;
            case 4:
                break;

            default:
                Console.WriteLine("Invalid Number");
                break;
        }
    }
}