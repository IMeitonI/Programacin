using System;

namespace Tarea_2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            double z = 3;
            Console.WriteLine("z=" + z);
            int y = 2;
            Console.WriteLine("y=" + y);
            double bGrados = 19.44;
            Console.WriteLine("b=" + bGrados);
            double b = bGrados * (Math.PI / 180.0);

            double a = Math.Atan(y / z);
            double aGrados = a * (180.0 / Math.PI);
            Console.WriteLine("a=" + aGrados);

            double x = z * (Math.Tan(a + b)) - y;
            Console.WriteLine("x=" + x);




        }
    }
}
