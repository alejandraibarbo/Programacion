using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_2_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para el triángulo rectangulo tzy ingrese los valores de t y el ángulo a 

            Console.WriteLine("colocar los datos de t: ");

            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("colocar los datos del angulo a: ");

            double a = double.Parse(Console.ReadLine());

            // angulo c

            Console.WriteLine("angulo c:");

            double c = (180 - 90 - a);
            double c1 = c * (Math.PI/180);
            Console.WriteLine(c);


            //lado z

            Console.WriteLine("lado z:");

            double z = (Math.Sin(c1) * t / 1);
            Console.WriteLine(z);

            //lado y

            Console.WriteLine("lado y:");

            double y = (Math.Sqrt(t * t + z * z));
            Console.WriteLine(y);
            

            
        }
    }
}
