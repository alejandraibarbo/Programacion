using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarera_2_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para el triángulo rectangulo tzy ingrese los valores de t y el ángulo a 

            Console.WriteLine("colocar los datos de z: ");

            double z = double.Parse(Console.ReadLine());

            Console.WriteLine("colocar los datos del angulo c: ");

            double c = double.Parse(Console.ReadLine());

            //angulo c en radianes 
            double c1 = (c * Math.PI)/180;

            // angulo a

            Console.WriteLine("angulo a:");

            double a = (180 - 90 - c);

            double a1 = (a * Math.PI )/ 180;
            Console.WriteLine(a);

            //lado y

            Console.WriteLine("lado y:");

            double y = (Math.Sin(a1)* z) /( Math.Sin(c1));
            Console.WriteLine(y);

            //lado t

            Console.WriteLine("lado t:");

            double t = (Math.Sqrt(y * y + z * z));

            Console.WriteLine(t);



        }
    }
}
