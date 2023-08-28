using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seno08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo del seno para ángulos de 0 a 8 grados");

            int numAngulos = 9; // Número de ángulos (0 a 8 grados) 
            double[] angulos = new double[numAngulos]; // Arreglo para almacenar los ángulos en grados
            double[] senos = new double[numAngulos];   // Arreglo para almacenar los valores del seno

            // Llenar el arreglo de ángulos
            for (int i = 0; i < numAngulos; i++)
            {
                angulos[i] = i;
            }

            // Calcular el seno para cada ángulo y almacenarlo en el arreglo de senos
            for (int i = 0; i < numAngulos; i++)
            {
                senos[i] = Math.Sin(DegreesToRadians(angulos[i]));
            }

            // Imprimir los resultados
            Console.WriteLine("Ángulo (grados) \t Seno");
            for (int i = 0; i < numAngulos; i++)
            {
                Console.WriteLine($"{angulos[i]} \t\t {senos[i]}");

            }
            Console.ReadLine();

        }

        // Función para convertir grados a radianes
        static double DegreesToRadians(double degrees)
        {
            return degrees * (Math.PI / 180);//para dejar en grados y poder graficar con 9 cifras quitamos el  *(Math.PI / 180). Porque si lo dejamos para que grafique bien tenemos que tener los 365 grados
        }

    }
      
}

