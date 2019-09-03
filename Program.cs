using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 15, 6, 12, 3, 18, 12, 6, 9 };
            int[] B = { 4, 0, 18, 16, 6, 6, 10, 14, 2, 12, 8, 2 };
            int[] u = new int[31];
            int[] todos = new int[A.Length + B.Length];
            int[] comunes = new int[A.Length + B.Length];
            for ( int i = 0; i < u.Length; i++)
            {
                u[i] = i;
            }

            //VISUALIZACON DE DATOS:

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + ",");
            }
            Console.WriteLine("");
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write(B[i] + ",");
            }
            Console.WriteLine("");
            for (int i = 0; i < u.Length; i++)
            {
                Console.Write(u[i] + ",");
            }
            Console.WriteLine("");

            //UNION

            for (int i = 0; i < A.Length; i++)
            {
                todos[i] = A[i];
            }

            for (int i = 0; i < B.Length; i++)
            {
                todos[A.Length + i] = B[i];
            }
            Array.Sort(todos);
            int[] tmp = new int[todos.Length];
            int contador = 0;
            for ( int i = 0; i< todos.Length-1; i++)
            {
                if (todos[i] != todos[i + 1 ])
                {
                    tmp[contador] = todos[i];
                    contador++;
                }
            }

            int[] union = new int[contador];
            for (int i = 0; i < union.Length; i++)
            {
                union[i] = tmp[i];

            }
            for (int i = 0; i < union.Length; i++)
            {
                Console.Write(union[i] + ",");
            }
            Console.WriteLine();

            







        }
    }
}
