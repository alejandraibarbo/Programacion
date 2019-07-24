using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea__4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("escriba los numeros por separado: ");

            Double B4 = int.Parse(Console.ReadLine());
            Double B3 = int.Parse(Console.ReadLine());
            Double B2 = int.Parse(Console.ReadLine());
            Double B1 = int.Parse(Console.ReadLine());
            Double B0 = int.Parse(Console.ReadLine());

            double b4 = B4 * (Math.Pow(2, 4));
            double b3 = B3 * (Math.Pow(2, 3));
            double b2 = B2 * (Math.Pow(2, 2));
            double b1 = B1 * (Math.Pow(2, 1));
            double b0 = B0 * (Math.Pow(2, 0));

            double Número = b4 + b3 + b2 + b1 + b0;

            Console.WriteLine(Número);
        }
    }
}
