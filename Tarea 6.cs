using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta1 = 0, carta2 = 0;
            int Puntos = 0;
            string continuar = "s";

            while (continuar =="s" && Puntos < 21)
            {
                carta1 = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);

                Console.WriteLine("carta1: " + carta1);
                Console.WriteLine("carta2: " + carta2);
                Puntos += carta1 + carta2;
                Console.WriteLine("Puntos: " + Puntos);


                if (Puntos > 21)
                {
                    Console.WriteLine("No puedes continuar");
                }
                else if (Puntos == 21)
                {
                    Console.WriteLine("Ganaste");
                }
                else
                {
                    Console.WriteLine("Tu total es: " + Puntos);
                    Console.Write("\nDesea continuar? (s/n)");
                    continuar = Console.ReadLine();

                }



            }
            Console.WriteLine("\nGracias por participar!");


        }
    }
}
