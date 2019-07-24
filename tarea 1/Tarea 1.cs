using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1__Programacion
{
    class Program
    {
        static void Main(string[] args)
        { //ingrese los datos
            Console.Write("colocar los datos y ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("colocar los datos z ");
            double z = double.Parse(Console.ReadLine());

            //teorema de Pitagoras 
            double t = Math.Sqrt(y*y+z*z);
            Console.WriteLine(t);

            //angulos C

            Console.WriteLine("valor del angulo c: ");
            double c = Math.Asin(z*1/t);
            double c1 = c * (180.0 / Math.PI);
  
            Console.WriteLine(c1);

            //Angulo a
            Console.WriteLine("valor del angulo a: ");

            double a = (180 - 90-c1);
            Console.WriteLine(a);
        }
    }
}



