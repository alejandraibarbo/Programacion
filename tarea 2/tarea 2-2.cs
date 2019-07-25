using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ejercicio 2

            //ingreso de datos

            Console.Write("ingrese los datos conocidos y ");

            double y = double.Parse(Console.ReadLine());
            Console.Write("ingrese los datos conocidos d° ");

            double dGrados = double.Parse(Console.ReadLine());
            Console.Write("ingrese los datos conocidos b° ");

            double bGrados = double.Parse(Console.ReadLine());

            // calculo de valores
            double f = 180 - 90 - dGrados;  //f= a+b
            double a = f-bGrados;
            double c = 90 - a;

            //conversion de angulo a raianes

            double c1 = c * (Math.PI / 180);
            double a1 = a * (Math.PI / 180);

            double z = y * Math.Sin(c1) / Math.Sin(a1);

            // salida

            Console.WriteLine(z);
        



        }
    }
}
