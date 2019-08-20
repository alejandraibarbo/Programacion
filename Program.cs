using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_8._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int vidas = 3, vidamax = 0, puntos = 0, turno = 0, unos = 0, consecutivo = 0;


            while (true)
            {
                Random rnd = new Random();

                int dado = rnd.Next(1, 12);
                turno++;

                puntos += dado;

                Console.WriteLine("Puntos: " + puntos);
                Console.WriteLine("Vidas: " + vidas);
                Console.WriteLine("Vida acumulada: " + vidamax);
                Console.WriteLine("Tiradas: " + consecutivo);

                if (dado == 1)
                {
                    unos++;
                }

                if (unos == 2)
                {
                    vidas--;
                    puntos -= 10;
                    unos = 0;
                }

                if (dado == 6)
                {
                    consecutivo++;
                }
                else
                {
                    consecutivo = 0;
                }

                if (dado == 6 && consecutivo == 2)
                {
                    Console.WriteLine(" Haz acumulado una vida");
                    vidamax++;
                    consecutivo = 0;
                    vidas += vidamax;
                }


                if (vidamax >= 3)
                {
                    vidamax = 3;
                    Console.WriteLine("Ya no puedes acumular mas vida");
                }


                Console.WriteLine("Dado: " + dado);

                if (vidas == 0) break;


                Console.WriteLine("Siguiente (1) ");
                int s = int.Parse(Console.ReadLine());
                if (s != 1)
                {
                    Console.WriteLine(" Acabo, sus puntos son" + dado);
                    break;
                }

            }
            Console.WriteLine("Sus puntos son: " + puntos + " Con " + turno + " turnos");
        }
    }
}
        
    

