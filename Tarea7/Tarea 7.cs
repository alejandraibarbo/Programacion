using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int Total = 0, contador = 0, counter = 0;

            string continuar = "s";

           

            while (continuar =="s")
            {
                counter += 1;
                Console.WriteLine("Contador: " + counter);

                int Dado = aleatorio.Next(1, 13);
                Console.WriteLine("Dado: " + Dado);
                if (counter <= 3)
                {
                    if (Total <100)
                    { 
                    Total += Dado;
                    Console.WriteLine("Total: " + Total);

                    Console.WriteLine("Desea continuar? (s/n)");

                    if (Console.ReadLine() != "s") break;


                   
                    }
                    
                    
                }

                 if (Dado % 2 == 1)
                {
                    Console.WriteLine("ups numero impar.");
                    break;
                }

                if (Dado == 11)
                {
                    contador += 1;
                }
                if (Dado == 12 && contador == 1)
                {
                    Console.WriteLine("Ganaste!");
                    Console.WriteLine("Total: " + Total);
                    

                }
               
                Console.WriteLine("Total: " + Total);
            }
        }
    }
}
