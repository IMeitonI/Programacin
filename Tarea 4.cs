using System;

namespace Tarea_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese votos partido a");
            int a =int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese votos partido b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese votos en blanco");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese votos anulados");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese número total población");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese porcentaje de la poblacion mayor de edad");
            double p = double.Parse(Console.ReadLine()) /100;
            
            int total = a + b + blancos + anulados;

            bool superior = total > n;
            bool diferencia = (a - b) < (0.1* total);
            bool inferior = total < (p * 0.3);
            bool ganador = a < b;

            if ((superior || diferencia) && inferior) Console.WriteLine("Las elecciones deben ser realizadas nuevamente");
            else if (ganador) { Console.WriteLine("Gana partido b"); }
            else { Console.WriteLine("Gana partido a"); }


        }
    }
}
