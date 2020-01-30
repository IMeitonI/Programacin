using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majo_Tarea_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario en SMMLV");
            int salario = int.Parse(Console.ReadLine());

             if (salario < 2){
                Console.WriteLine("Tarifa A");
             }
              else if (2 <= salario && salario <= 4) 
              {
                Console.WriteLine("Tarifa B");
              }
              else {
                Console.WriteLine("Tarifa C");
              }



        }
    }
}
