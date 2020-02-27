using System;

namespace Tarea_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double maximo = 0;
            double[] cx = { 0, 2, 3, 7 };
            double[] cy = { 0, 1, 5, 6 };

            double m1 = (cy[1] - cy[0]) / (cx[1] - cx[0]);
            double m2 = (cy[2] - cy[0]) / (cx[2] - cx[0]);
            double m3 = (cy[3] - cy[0]) / (cx[3] - cx[0]);
            double m4 = (cy[2] - cy[1]) / (cx[2] - cx[1]);
            double m5 = (cy[3] - cy[2]) / (cx[3] - cx[2]);
            double m6 = (cy[3] - cy[1]) / (cx[3] - cx[1]);

            if (m1 == m2 && m2 == m3 && m3 == m4 && m4 == m5 && m5 == m6)
            {
                Console.WriteLine("pertenecen a una misma recta");
            }
            else
            {
                Console.WriteLine("No pertenecen a la misma recta");
            }

            double d1 = Math.Sqrt(Math.Pow((cy[1] - cy[0]), 2) + Math.Pow((cx[1] - cx[0]), 2));
            double d2 = Math.Sqrt(Math.Pow((cy[2] - cy[0]), 2) + Math.Pow((cx[2] - cx[0]), 2));
            double d3 = Math.Sqrt(Math.Pow((cy[3] - cy[0]), 2) + Math.Pow((cx[3] - cx[0]), 2));
            double d4 = Math.Sqrt(Math.Pow((cy[2] - cy[1]), 2) + Math.Pow((cx[2] - cx[1]), 2));
            double d5 = Math.Sqrt(Math.Pow((cy[3] - cy[2]), 2) + Math.Pow((cx[3] - cx[2]), 2));
            double d6 = Math.Sqrt(Math.Pow((cy[3] - cy[1]), 2) + Math.Pow((cx[3] - cx[1]), 2));

            if (d1 > maximo)
            {
                maximo = d1;
            }
            if (d2 > maximo)
            {
                maximo = d2;
            }
            if (d3 > maximo)
            {
                maximo = d3;
            }
            if (d4 > maximo)
            {
                maximo = d4;
            }
            if (d5 > maximo)
            {
                maximo = d5;
            }
            if (d6 > maximo)
            {
                maximo = d6;
            }

            Console.WriteLine("La mayor distancia: " + maximo);

        }
    }
}
      
    
