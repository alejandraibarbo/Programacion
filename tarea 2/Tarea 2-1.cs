using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ejercicio 1

            Console.Write(" escriba el valor del angulo b°: ");
            double bGrados = double.Parse(Console.ReadLine());

            Console.Write(" escriba el valor de z: ");
            double z = double.Parse(Console.ReadLine());

            Console.Write(" escriba el valor de y: ");
            double y = double.Parse(Console.ReadLine());

            //operaciones 

            double c = Math.Atan(z / y);
            double c1 = c * 180 /Math.PI;

            double e = 180 - c1;
                
            double t = Math.Sqrt(z * z + y * y);
            double d = 180 - e - bGrados;

            //Radianes 

            double b1 = bGrados * Math.PI / 180;
            double d1 = d * Math.PI / 180;

            double x = t * Math.Sin(b1) / Math.Sin(d1);

            Console.Write("Lado x: ");
            Console.WriteLine(x);


        }
    }
}
