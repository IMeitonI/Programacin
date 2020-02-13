using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();
            int carta = 0, total = 0;
            string continuar = "s";
            string continuar2 = "r";

            while (continuar2 == "r")
            {
                total = 0;
                carta = aleatorio.Next(1, 11);
                total += carta;
                Console.WriteLine("carta: " + carta);
                carta = aleatorio.Next(1, 11);
                total += carta;
                Console.WriteLine("carta: " + carta);
                Console.WriteLine("Total: " + total);
                Console.WriteLine("Desea tomar otra carta? (s/n)");
                continuar = Console.ReadLine();
                while (total < 21 && continuar == "s")
                {
                    carta = aleatorio.Next(1, 11);
                    Console.WriteLine("carta: " + carta);
                    total += carta;
                    Console.WriteLine("Total: " + total);
                  
                  
                    if (total > 21)
                    {
                       
                        Console.WriteLine("Has perdido. Fin del juego");

                        Console.WriteLine("Desea reiniciar el juego? (r/n)");
                        continuar2 = Console.ReadLine();
                    }

                    else if (total == 21)
                    {
                        
                        Console.WriteLine("Ganaste");

                        Console.WriteLine("Desea reiniciar el juego? (r/n)");
                        continuar2 = Console.ReadLine();
                    }
                    else Console.WriteLine("Desea tomar otra carta? (s/n)");
                    continuar = Console.ReadLine();

                }
                    

                   

                


            }


        }
    }
}
