using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int vidas = 3,  puntos = 0, turno = 0, vidamax=0, puntos1 = 0;
           

            while (true)
            {
               turno++;
              Console.WriteLine("Turno: " + turno);
                Random rnd = new Random();

                int dado1 = rnd.Next(1, 7);
                int dado2 = rnd.Next(1, 27);
              

                puntos += dado1;
                Console.WriteLine("Dado1: " + dado1);
                Console.WriteLine("Puntos: " + puntos);
                Console.WriteLine("Vida: " + vidas);


              /*
                    if (turno == 2)
                   {
                    vidas--;

                }

                if (turno == 3)
                {
                    puntos += dado2;
                    Console.WriteLine("Dado2: " + dado2);

                    if (dado1 == dado2)
                    {
                        vidas++;
                        Console.WriteLine("Ganaste una vida");
                    }
                }

                
                Console.WriteLine("Siguiente (1) ");
                int s = int.Parse(Console.ReadLine());
                if (s != 1)
                {
                    Console.WriteLine(" Acabo, sus puntos son: " + dado1 + dado2);
                    break;
                }*/
                if (turno % 2 == 0)
                {
                    vidas--;
                }
                else
                {
                    if(turno > 1) { 
                    puntos1 += dado2;
                    Console.WriteLine("Dado2: " + dado2);
                        }

                    if (dado1 == dado2)
                    {
                        vidas++;
                        Console.WriteLine("Ganaste una vida");
                    }
                }
                if (vidamax >= 3)
                {
                    vidamax = 3;
                    Console.WriteLine("Ya no puedes acumular mas vida");
                }
                if (vidas == 0)
                {
                    Console.WriteLine("Fin del Juego");
                    break;
                }
                Console.WriteLine("Siguiente (1) ");
                int s = int.Parse(Console.ReadLine());
                if (s != 1)
                {
                    int Total = puntos + puntos1;
                    Console.WriteLine(" Acabo, sus puntos son: " + Total);
                    break;
                }
            }

        }
    }
}


