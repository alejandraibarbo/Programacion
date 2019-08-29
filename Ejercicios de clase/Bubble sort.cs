using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = {"S","L","M","K","M"};
            int[] Notas = { 1, 2, 1, 5, 4 };
            int Pos;
            string name;
            
           

            for (int i = 0; i < Notas.Length -1; i++)
            {
                for (int j = 0; j < Notas.Length - 1 ; j++)
                {
                    if (Notas[j + 1] > Notas[j])
                    {
                        Pos = Notas[j + 1];
                        Notas[j + 1] = Notas[j];
                        Notas[j] = Pos;

                        name = nombre[j+1];
                        nombre[j + 1] = nombre[j];
                        nombre[j] = name;

                    }
                    
                }
            }
            for (int i = 0; i < Notas.Length ; i++)
            {
                Console.WriteLine("\nPosicion: " + Notas[i] +" Persona: " + nombre[i]);
            }

                    }
                }

            }



        
    

