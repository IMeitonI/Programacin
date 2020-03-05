using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavavava
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta = 0, jugador = 0, max = 0, tpm = 0;
            string continuar = "s", nombre = "", nombremayor = "", tpmn= "";
            Console.WriteLine("Ingrese número de jugadores (Minimo 2 jugadores y maximo 5)");
            int n = int.Parse(Console.ReadLine());
            int[] puntos = new int[n];
            string []nombres = new string[n];

            while (n < 3 || n > 6)
            {
                Console.WriteLine("Error. (Minimo 2 jugadores, maximo 5)");
                n = int.Parse(Console.ReadLine());
                n++;
            }

            while (jugador < n)
            {
                Console.WriteLine("\n\nBienvenido jugador: " + (jugador+1));
                puntos[jugador] = 0;
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();
                nombres[jugador] = nombre;

                while (continuar == "s" && puntos[jugador] < 21)
                {
                    carta = aleatorio.Next(1, 11);
                    puntos[jugador] += carta; 
                    Console.WriteLine("carta: " + carta);
                    carta = aleatorio.Next(1, 11);
                    puntos[jugador] += carta;
                    Console.WriteLine("carta: " + carta);
                    Console.WriteLine("Total: " + puntos[jugador]);
                    Console.WriteLine("Desea tomar otra carta? (s/n)");
                    continuar = Console.ReadLine();

                    while (continuar != "s" && continuar != "n")
                    {
                        Console.WriteLine("Error. Ingrese (s/n)");
                        continuar = Console.ReadLine();
                    }

                    while (puntos[jugador] < 21 && continuar == "s")
                    {
                        carta = aleatorio.Next(1, 11);
                        Console.WriteLine("carta: " + carta);
                        puntos[jugador] += carta;
                        Console.WriteLine("Total: " + puntos[jugador]);

                        if (puntos[jugador] > max && puntos[jugador] <= 21)
                        {
                            max = puntos[jugador];
                            nombremayor = nombre;
                        }

                        if (puntos[jugador] > 21)
                        {
                            puntos[jugador] = 0;
                            Console.WriteLine("Has perdido.");
                            continuar = "n";
                            break;
                        }

                        else if (puntos[jugador] == 21)
                        {
                            Console.WriteLine("Ganaste.");
                            continuar = "n";
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Desea tomar otra carta? (s/n)");
                            continuar = Console.ReadLine();
                        }

                        while (continuar != "s" && continuar != "n")
                        {
                            Console.WriteLine("Error. Ingrese (s/n)");
                            continuar = Console.ReadLine();
                        }
                    }
                }
                Console.WriteLine("Gracias por participar");
                jugador++;
                continuar = "s";

            }
            
      

            for (int i = 0; i < puntos.Length- 1; i++)
            {
                for (int j = 0; j < puntos.Length-1; j++)
                    if (puntos[j]>puntos[j+1]){
                        tpm = puntos[j];
                        puntos[j] = puntos[j + 1];
                        puntos[j + 1] = tpm;

                        tpmn = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = tpmn;


                    }

            }

            Console.WriteLine("puntos: " + puntos[0] + "nombre: " + nombres[0]);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("puntos: " + puntos[i] + "nombre: " + nombres[i]);
            }
        }
    }
}
