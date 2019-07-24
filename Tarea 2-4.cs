using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_4
{
    class Program
    {
        static void Main(string[] args)
        {

            // ingreso de datos
            Console.WriteLine("ingrese el lado w: ");
            double w = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el lado t: ");
            double t =  double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el angulo c: ");
            double cGrados = double.Parse(Console.ReadLine());

            //operaciones

            double e = 180 - cGrados;

            double e1 = e * (Math.PI / 180);
           
            double d = (Math.Asin (t * Math.Sin(e1) / w));

            double d1 = d * (180 / Math.PI);

            double b = 180-d1-e ;

            double b1 = (b * Math.PI / 180);

            double x = w * Math.Sin(b1) / Math.Sin(e1);

            Console.Write("lado x = ");

            Console.WriteLine(x);

        }
    }
}
