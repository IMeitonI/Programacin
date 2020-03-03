using System;

namespace Tarea_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta = 0, jugador = 1, max = 0, min = 22, medio = 0;
            string continuar = "s", nombre = "", nombremayor = "", segundo="";
            Console.WriteLine("Ingrese número de jugadores (Minimo 2 jugadores y maximo 5)");
            int n = int.Parse(Console.ReadLine());
            n++;
            int[] puntos = new int[n];

            while (n < 3 || n > 6)
            {
                Console.WriteLine("Error. (Minimo 2 jugadores, maximo 5)");
                n = int.Parse(Console.ReadLine());
                n++;
            }

            while( jugador < n)
            {
                Console.WriteLine("\n\nBienvenido jugador: " + jugador);
                
                puntos[jugador]  = 0;
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();

                while (continuar == "s" && puntos[jugador]  < 21)
                {
                    carta = aleatorio.Next(1, 11);
                    puntos[jugador]  += carta;
                    Console.WriteLine("carta: " + carta);
                    carta = aleatorio.Next(1, 11);
                    puntos[jugador]  += carta;
                  
                    Console.WriteLine("carta: " + carta);
                    Console.WriteLine("Total: " + puntos[jugador] );
                    Console.WriteLine("Desea tomar otra carta? (s/n)");
                    continuar = Console.ReadLine();

                    while (continuar != "s" && continuar != "n")
                    {
                        Console.WriteLine("Error. Ingrese (s/n)");
                        continuar = Console.ReadLine();
                    }

                    while (puntos[jugador]  < 21 && continuar == "s")
                    {
                        carta = aleatorio.Next(1, 11);
                        Console.WriteLine("carta: " + carta);
                        puntos[jugador]  += carta;
                       
                        Console.WriteLine("Total: " + puntos[jugador] );

                        if (puntos[jugador]  > max && puntos[jugador]  <= 21)
                        {
                            max = puntos[jugador] ;
                            nombremayor = nombre;
                        }
                        if (puntos[jugador]  < min && puntos[jugador]  <= 21)
                        {
                            min = puntos[jugador] ;
                        }
                        if (puntos[jugador]  < max && puntos[jugador]  > min)
                        {
                            medio = puntos[jugador] ;
                            segundo = nombre;
                        }

                        if (puntos[jugador]  > 21)
                        {
                            Console.WriteLine("Has perdido.");
                            continuar = "n";
                            break;
                        }

                        else if (puntos[jugador]  == 21)
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
            Console.WriteLine("Ganador: " + nombremayor + " Segundo lugar: "+ segundo);
            for(int j =1; j <n; j++)
            {
                Console.WriteLine("punto " +j +" "+ puntos[j]);
            }
        }
    }
}
