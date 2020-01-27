using System;

namespace Tarea_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dGrados = 36.87;
            Console.WriteLine("d=" + dGrados);
            double bGrados = 19.44;
            Console.WriteLine("b=" + bGrados);
            double y = 2;

            // f=(aGrados + bGrados)
            double f = 180 - (90 + dGrados);
            double aGrados = f - bGrados;
            Console.WriteLine("a=" + aGrados);
            double a = aGrados * (Math.PI / 180.0);

            double z = y / Math.Tan(a);
            Console.WriteLine("z=" + z);

        }
    }
}
