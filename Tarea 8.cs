using System;

namespace aahhhhh
{
    class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();
            int dado = 0, dado2 = 0, puntos = 0, vidas = 3;
            double turnos1 = 0, turnos2 = 0;
            string continuar = "s";

            while (continuar == "s")
            {
                if (turnos2 % 3 == 0 && turnos2 > 2)
                {

                    dado = aleatorio.Next(1, 7);
                    dado2 = aleatorio.Next(1, 7);
                    Console.WriteLine("Dado: " + dado);
                    Console.WriteLine("Dado2: " + dado2);
                    puntos += dado + dado2;
                    Console.WriteLine("Puntos: " + puntos);
                    turnos1++;
                    turnos2++;

                    if (dado == dado2)
                    {
                        vidas++;
                        Console.WriteLine("Ganaste una vida");
                        Console.WriteLine("vidas: " + vidas);
                    }
                }
                else
                {
                    dado = aleatorio.Next(1, 7);
                    Console.WriteLine("Dado: " + dado);
                    puntos += dado;
                    Console.WriteLine("Puntos: " + puntos);
                    turnos1++;
                    turnos2++;
                }


                if (turnos1 % 3 == 0 )
                {
                    vidas--;
                    Console.WriteLine("perdiste una vida");
                    Console.WriteLine("vidas: " + vidas);
                }

                if (puntos >= 100)
                {
                    Console.WriteLine("Ganaste");
                    continuar = "n";
                }
                else if (vidas == 0)
                {
                    Console.WriteLine("perdiste");
                    continuar = "n";
                }
                else
                {
                    Console.WriteLine("Desea volver a tirar? (s/n)");
                    continuar = Console.ReadLine();
                }
            }

            Console.WriteLine("Su total fue " + puntos + " puntos");
        }
    }
}
