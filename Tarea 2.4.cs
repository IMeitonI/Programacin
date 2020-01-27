using System;

namespace Tarea_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = 5;
            Console.WriteLine("w=" + w);
            double t = 3.61;
            Console.WriteLine("t=" + t);
            double cGrados = 56.31;
            Console.WriteLine("c=" + cGrados);
            double c = cGrados * (Math.PI / 180.0);

            double z = t * Math.Sin(c);
            Console.WriteLine("z=" + z);
            double y = z / Math.Tan(c);
            Console.WriteLine("y=" + y);

            double x = Math.Sqrt(Math.Pow(w, 2) - Math.Pow(z, 2)) - y;
            Console.WriteLine("x=" + x);
                
        }
    }
}
