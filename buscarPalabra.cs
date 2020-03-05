using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majolo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase");
            string frase = Console.ReadLine();
            frase = frase.ToUpper();
            int contador = 0;
            Console.WriteLine("Ingrese la palabra buscada");
            string palabra = Console.ReadLine();
            palabra = palabra.ToUpper();
            int n = palabra.Length;
            

            for (int i = 0; i < frase.Length - n; i++)
            {
                string formada = "";
                
                for (int j = 0; j < n; j++)
                {
                    formada += frase[i + j];
                }
               
                if (formada == palabra)
                {
                    contador++;
                    Console.WriteLine("Palabra encontrada. " + "posicion: " + i +  " contador: " + contador);
                   

                }
            }

        }
    }
}
