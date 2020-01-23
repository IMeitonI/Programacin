using System;

namespace Tarea_1._2_parte
{
    class Program
    {
        static void Main(string[] args)
        {
            double t = 3.61;
            Console.WriteLine("t=" + t);
            double aGrados = 33.69;
            Console.WriteLine("a=" + aGrados);
            double a = aGrados * (Math.PI / 180.0);

            double angulo90 = 90;
            double c = 180 - (angulo90 + aGrados);
            Console.WriteLine("c=" + c);

            double y = (Math.Sin(a)) * t;
            Console.WriteLine("y=" + y);

            double z = Math.Sqrt(Math.Pow(t, 2) - Math.Pow(y, 2));
            Console.WriteLine("z=" + z);


        }
    }
}
