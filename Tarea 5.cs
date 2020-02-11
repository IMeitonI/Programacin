using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario mensual");
            double salarioMen = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tipo de contrato. Ingrese 1 para dependiente y 2 para independiente");
            int tipoCon = int.Parse(Console.ReadLine());
           
            switch (tipoCon) {

                case 1:

                    double baseCo = salarioMen * 0.40;

                    if (baseCo < 877843)
                    {
                        baseCo = 877843;
                    }
                    double EPS = baseCo * (0.04);
                    double Pension = baseCo * (0.04);
                    Console.WriteLine("eps:$" + EPS);
                    Console.WriteLine("pension:$" + Pension);

                    double salarioR = salarioMen - (EPS + Pension);
                    double prima = salarioMen;
                    double salarioAn = (salarioR * 12) + prima;
                    Console.WriteLine("Salario real:$" + salarioR);
                    Console.WriteLine("Salario anual:$" + salarioAn);
                    break;
            }

            switch (tipoCon)  {

                case 2:
                    Console.WriteLine("Ingrese su nivel de riesgo de 1 a 5, siendo 1 el menor nivel de riesgo y 5 el mayor");
                    double ARL = double.Parse(Console.ReadLine());
                    
                    

                    switch (ARL) {
                        case 1:
                            ARL = 0.522 / 100;
                            break;
                        case 2:
                            ARL = 1.044 / 100;
                            break;
                        case 3:
                            ARL = 2.436 / 100;
                            break;
                        case 4:
                            ARL = 4.350 / 100;
                            break;
                        case 5:
                            ARL = 6.960 / 100;
                            break;
                    }
                   

                    double baseCo = salarioMen * 0.40;

                    if (baseCo < 877843)
                    {
                        baseCo = 877843;
                    }

                    double EPS = baseCo * (0.125);
                    double Pension = baseCo * (0.16);
                    double Riesgo = baseCo * (ARL);
                    Console.WriteLine("eps:$" + EPS);
                    Console.WriteLine("pension:$" + Pension);
                    Console.WriteLine("ARL:$" + Riesgo);
                    double salarioR = salarioMen - (EPS + Pension + Riesgo);
                    double salarioAn = salarioR * 12;
                    Console.WriteLine("Salario real:$" + salarioR);
                    Console.WriteLine("Salario anual:$" + salarioAn);
                    break;
            }






        }
    }
}
