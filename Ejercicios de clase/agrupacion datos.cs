using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {      
            double[] CoordsX = { 0, 2, 3, 7 };
            double[] CoordsY = { 0, 1, 5, 6 };         

            double m0 = (CoordsY[1] - CoordsY[0]) / (CoordsX[1] - CoordsX[0]);
            double m1 = (CoordsY[2] - CoordsY[1]) / (CoordsX[2] - CoordsX[1]);
            double m2 = (CoordsY[3] - CoordsY[2]) / (CoordsX[3] - CoordsX[2]);

            double b0 = (CoordsY[0] - m0*(CoordsX[0]));
            double b1 = (CoordsY[1] - m1 * (CoordsX[1]));
            double b2 = (CoordsY[2] - m2 * (CoordsX[2]));

            double d1 = Math.Sqrt(((CoordsX[1] - CoordsX[0]) * (CoordsX[1] - CoordsX[0])) + ((CoordsY[1] - CoordsY[0])*(CoordsY[1] - CoordsY[0])));
            double d2 = Math.Sqrt(((CoordsX[2] - CoordsX[1]) * (CoordsX[2] - CoordsX[1])) + ((CoordsY[2] - CoordsY[1]) * (CoordsY[2] - CoordsY[1])));
            double d3 = Math.Sqrt(((CoordsX[3] - CoordsX[2]) * (CoordsX[3] - CoordsX[2])) + ((CoordsY[3] - CoordsY[2]) * (CoordsY[3] - CoordsY[2])));

           

            Console.WriteLine("Pendientes " + m0 + " | " + m1 + " | " + m2);
            Console.WriteLine("Intersectos "+ b0 + " | " + b1 + " | " + b2);
            Console.WriteLine("Distancias " + " 1 = " + d1 + " 2 = " + d2 + " 3 = " + d3);

            if (d1 >= d2 && d1 >= d3) Console.WriteLine("\nLa distancia mayor es " + d1);
            else if (d1 <= d2 && d2 >= d3) Console.WriteLine("\nLa ditsncia mayor es " + d2);
            else Console.WriteLine("La mayor distancia es " + d3);
            
            if (m0 == m1 && m1==m2 && b0==b1 && b1==b2) Console.Write("Estan en la misma recta ");
            else Console.WriteLine("No estan en la misma recta ");

            
            
            

        }
    }
}
