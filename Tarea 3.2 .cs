using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majo_Tarea_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese su salario en SMMLV");
            int salario = int.Parse(Console.ReadLine());
        
                       
            if (salario < 2)
            {
                Console.WriteLine("Tarifa A");
                Console.WriteLine("Cuota moderada: $3400" );
            }
            else if (2 <= salario && salario <= 5)
            {
                Console.WriteLine("Tarifa B");
                Console.WriteLine("Cuota moderada: $13500");
            }
            else
            {
                Console.WriteLine("Tarifa C");
                Console.WriteLine("Cuota moderada: $35600");
            }

        }
    }
}
