using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //INGRESO DE DATOS
            Console.Write("ingrese su Salario Mensual ");
            double neto = double.Parse(Console.ReadLine());
            Console.WriteLine("¿Trabaja de forma Dependiente o Independiente?");
            Console.WriteLine("1 - Independiente, 2 - Dependiente ");
            int opcion = int.Parse(Console.ReadLine());
            double ARL = 0;

            if (opcion == 2)
            {
                double salario = neto * 40 / 100;
                double pension = salario * 4 / 100;
                double EPS = salario * 4 / 100;

                double Deducciones = -pension - EPS - ARL;
                Console.Write("Total deducciones ");
                Console.WriteLine(Deducciones);
                double SalarioReal = neto + Deducciones;
                Console.WriteLine("Salario real ");
                Console.WriteLine(SalarioReal);
                double SalarioAnual = SalarioReal * 12 + neto;
                Console.WriteLine("Su salario anual es ");
                Console.WriteLine(SalarioAnual);
            }
            if (opcion == 1)
            {
                double salario2 = neto * 40 / 100;
                double pension2 = salario2 * 16 / 100;
                double EPS2 = salario2 * 12.5 / 100;

                Console.WriteLine("Marque del 1 al 5 su nivel de riesgo ");
                int riesgo = int.Parse(Console.ReadLine());
                if (riesgo == 1)
                {
                    ARL = salario2 * 0.522 / 100;

                    if (riesgo == 2)
                    {
                        ARL = salario2 * 1.044 / 100;
                    }
                    if (riesgo == 3)
                    {
                        ARL = salario2 * 2.436 / 100;
                    }
                    if (riesgo == 4)
                    {
                        ARL = salario2 * 4.350 / 100;
                    }
                    if (riesgo == 5)
                    {
                        ARL = salario2 * 6.960 / 100;

                    }



                    double deducciones = -pension2 - EPS2 - ARL;
                    Console.WriteLine("Sus Deducciones son ");
                    Console.WriteLine(deducciones);
                    double SalarioReal2 = neto + deducciones;
                    Console.WriteLine("Salario real " + SalarioReal2) ;
                    double SalarioAnual2 = SalarioReal2 * 12 ;
                    Console.WriteLine("Su salario anual es " + SalarioAnual2);
                    
                }
            }

        }
    }
}