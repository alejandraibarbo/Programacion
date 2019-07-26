using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingresa tu salario mensual: ");
            double salario = double.Parse(Console.ReadLine());
            double smmlv = 828116;


            if (salario < 2 * smmlv)
            {
                Console.WriteLine("Pagas tarifa A ");
                if (salario < 1656231)   //menos de 

                {
                    Console.WriteLine("Pagas 3200 por la cita general ");
                }
            }
            else if (2 * smmlv <= salario && salario <= 4 * smmlv)    //entre a y b
            {
                Console.WriteLine("Pagas la tarifa B ");

                if (1656232 <= salario && salario <= 4140580)
                {
                    Console.WriteLine("Pagas 12700 por la cita general.");
                }
            }
            else if (salario > 5 * smmlv)      //Más de 
            {
                Console.WriteLine("Pagas tarifa C ");
                if(salario > 4140581)
                {
                    Console.WriteLine("Pagas 33500 por la cita general.");
                }


            }






        }
    }
}
