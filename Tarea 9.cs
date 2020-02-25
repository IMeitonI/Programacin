using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta = 0, total = 0, jugador = 1, max = 0;
            string continuar = "s", nombre ="",nombremayor = "";
            Console.WriteLine("Ingrese número de jugadores (Minimo 2 jugadores y maximo 5)");
            int n = int.Parse(Console.ReadLine());
            n++;
            
            while (n < 3 || n > 6)
            {
                Console.WriteLine("Error. (Minimo 2 jugadores, maximo 5)");
                n = int.Parse(Console.ReadLine());
                n++;
            }
           
            while (jugador < n){
                Console.WriteLine("\n\nBienvenido jugador: " + jugador);
                total = 0;
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();
                
                while (continuar == "s" && total < 21){
                    carta = aleatorio.Next(1, 11);
                    total += carta;
                    Console.WriteLine("carta: " + carta);
                    carta = aleatorio.Next(1, 11);
                    total += carta;
                    Console.WriteLine("carta: " + carta);
                    Console.WriteLine("Total: " + total);
                    Console.WriteLine("Desea tomar otra carta? (s/n)");
                    continuar = Console.ReadLine();
                     
                    while(continuar !="s" && continuar !="n"){
                        Console.WriteLine("Error. Ingrese (s/n)");
                        continuar = Console.ReadLine();
                    }

                    while (total < 21 && continuar == "s"){
                        carta = aleatorio.Next(1, 11);
                        Console.WriteLine("carta: " + carta);
                        total += carta;
                        Console.WriteLine("Total: " + total);

                        if (total > max && total <=21){
                            max = total;
                            nombremayor = nombre;
                        }

                        if (total > 21){
                            Console.WriteLine("Has perdido.");
                            continuar = "n";
                            break;
                        }

                        else if (total == 21){
                            Console.WriteLine("Ganaste.");
                            continuar = "n";
                            break;
                        }
                        else {
                            Console.WriteLine("Desea tomar otra carta? (s/n)");
                            continuar = Console.ReadLine();
                        }
                          
                        while (continuar != "s" && continuar != "n"){
                            Console.WriteLine("Error. Ingrese (s/n)");
                            continuar = Console.ReadLine();
                        }
                    }
                }
                Console.WriteLine("Gracias por participar");
                jugador++;
                continuar = "s";

            }
            Console.WriteLine("Ganador: "+ nombremayor);

        }
    }
}
