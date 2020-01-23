using System;

namespace Tarea_1._3_parte
{
    class Program
    {
        static void Main(string[] args)
        {
            double z = 3;
            Console.WriteLine("z=" + z);
            double cGrados = 56.31;
            Console.WriteLine("c=" + cGrados);
            double c = cGrados * (Math.PI / 180.0);

            double y = z / (Math.Tan(c));
            Console.WriteLine("y=" + y);

            double aGrados = 180 - (90 + cGrados);
            Console.WriteLine("a=" + aGrados);

            double t = Math.Sqrt(Math.Pow(y, 2) + (Math.Pow(z, 2)));
            Console.WriteLine("t=" + t);
        }
    }
}
