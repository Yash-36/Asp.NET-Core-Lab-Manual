using System;
using System.Collections;
delegate void TrafficDel();

namespace Lab_4
{
    internal class TrafficSignal
    {
        public void dt()
        {
            TrafficDel t1 = new TrafficDel(Yellow);
            TrafficDel t2 = new TrafficDel(Green);
            TrafficDel t3 = new TrafficDel(Red);
            TrafficDel t4 = new TrafficDel(Blue);

            t1.Invoke();
            t2.Invoke();
            t3.Invoke();
            t4.Invoke();
        }

        public static void Yellow()
        {
            Console.WriteLine("Yellow Light Signal To Get Ready");
        }
        public static void Green()
        {
            Console.WriteLine("Green Light Signal To Go");
        }
        public static void Red()
        {
            Console.WriteLine("Red Light Signal To Stop");
        }
        public static void Blue()
        {
            Console.WriteLine("Blue Light Signal To Stop");
        }
    }
}
