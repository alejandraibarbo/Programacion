using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 3

            Console.Write("ingrese los datos del lado W: ");
            double w = double.Parse(Console.ReadLine());

            Console.Write("ingrese los datos del lado x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("ingrese los datos del angulo d°: ");
            double dGrados = double.Parse(Console.ReadLine());

            //Solucion

            double d1 = dGrados*(Math.PI/180);
            double z = w*(Math.Sin(d1));

            double f = Math.Sqrt(w * w - z * z);
            double y = f - x;

            Console.Write("lado y: ");
            Console.WriteLine(y);

        }
    }
}
