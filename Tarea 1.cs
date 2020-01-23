using System;

namespace Tarea_1
{
	class Program
	{
		static void Main(string[] args)
		{
			double y = 2;
			Console.WriteLine("y=" + y);
			double z = 3;
			Console.WriteLine("z=" + z);
			double t = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(z, 2));
			Console.WriteLine("t=" + t);

			double cAngulo = Math.Asin(z / t);
			double cAnguloF = cAngulo * (180.0 / Math.PI);
			Console.WriteLine("Angulo de c: " + cAnguloF);

			double aAngulo = Math.Acos(z / t);
			double aAngulof = aAngulo * (180.0 / Math.PI);
			Console.WriteLine("Angulo de a: " + aAngulof);

				 
		}
	}
}
