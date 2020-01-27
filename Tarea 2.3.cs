using System;

namespace Tarea_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = 5;
            Console.WriteLine("w=" + w);
            double dGrados = 36.87;
            Console.WriteLine("d=" + dGrados);
            int x = 2;
            Console.WriteLine("x=" + x);
            double d = dGrados * (Math.PI / 180.0);

            double z = w * Math.Sin(d);
            Console.WriteLine("z=" + z);

            // f= (a + b)
            double fGrados = 180 - (90 + dGrados);
            double f = fGrados * (Math.PI/180.0);
            double y = (w * Math.Sin(f)) - x;
            Console.WriteLine("y=" + y);



        }
    }
}
