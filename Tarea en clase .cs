using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majo13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, puntos = 0, vidas = 3, dadoe = 2;
            double contador2 = 0, contador3 = 0;
            string continuar = "s", continuar2 ="s";

            while (continuar == "s")
            {
                if(dadoe == 2 || dadoe == 1)
                {
                    Console.WriteLine("Desea utilizar un dado especial? (s/n)");
                    continuar2 = Console.ReadLine();
                }

                if ((dadoe == 2 || dadoe == 1) && (continuar2 == "s"))
                {

                    if (continuar2 == "s")
                    {
                        dado = aleatorio.Next(1, 13);
                        Console.WriteLine("Dado especial: " + dado);
                        puntos += dado;
                        Console.WriteLine("Puntos: " + puntos);

                        dadoe--;
                        Console.WriteLine("te quedan: " + dadoe + " dados especiales");
                    }
                }
                else
                {
                    dado = aleatorio.Next(1, 7);
                    Console.WriteLine("Dado: " + dado);
                    puntos += dado;
                    Console.WriteLine("Puntos: " + puntos);
                }
                                        

                    if (dado == 1) contador2++;
                    if (contador2 % 2 == 0 && dado ==1)
                    {
                        vidas--;
                        puntos -= 10;
                        Console.WriteLine("Perdiste 1 vida y 10 puntos. Sacaste dos veces un 1");
                        Console.WriteLine("vidas: " + vidas);
                        Console.WriteLine("Puntos: " + puntos);
                    }
                    if (dado == 6) contador3++;
                    else contador3 = 0;
                    if (contador3 == 2 && vidas < 3)
                    {
                        vidas++;
                        Console.WriteLine("Ganaste una vida. Dos 6 consecutivos");
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
