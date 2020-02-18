using System;

namespace Tarea_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, puntos = 0;
            double contador1 = 0, contador2 = 0;
            string continuar = "s";
            

            while (continuar == "s")
            {
                dado = aleatorio.Next(1,13);
                Console.WriteLine("Dado: " + dado);
                puntos += dado;
                Console.WriteLine("Puntos: " + puntos);
                contador1++;
                int myint = Convert.ToInt32(dado);
                                                            
                if (contador1 < 3 )
                {
                    
                    continuar = "s";
                }
                else
                {   if ( dado == 12)
                    {
                        contador2++;
                    } if (dado == 10 && contador2 == 1)
                    {
                        Console.WriteLine("Ganaste");
                        continuar = "n";
                    }


                    else if (puntos >= 100)
                    {
                        Console.WriteLine("Ganaste");
                        continuar = "n";
                    }

                    else if (myint % 2 == 0)
                    {
                        Console.WriteLine("Desea volver a tirar? (s/n)");
                        continuar = Console.ReadLine();
                        
                    }
                    else if (contador1 > 3)
                    {
                        Console.WriteLine("Perdiste. Número impar: " + dado, myint);
                        continuar = "n";
                        
                    }
                    else
                    {
                        Console.WriteLine("Desea volver a tirar? (s/n)");
                        continuar = Console.ReadLine();

                    }
                }
            }
            Console.WriteLine("Su total fue " + puntos + " puntos");


        }
    }
}
