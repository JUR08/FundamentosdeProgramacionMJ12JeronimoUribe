using System;

namespace Taller4Matrices1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por
            pantalla la suma de los elementos de cada columna.*/
            int[,] mat = new int[10, 20];
            int suma = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[0, j] = (10);
                    mat[1, j] = (20);
                    mat[2, j] = (30);
                    mat[3, j] = (40);
                    mat[4, j] = (50);
                    mat[5, j] = (60);
                    mat[6, j] = (70);
                    mat[7, j] = (80);
                    mat[8, j] = (90);
                    mat[9, j] = (100);
                }
            }
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                suma = 0;
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    suma += mat[i, j];
                }
                Console.WriteLine($"Suma de la columna {j}: {suma}");
            }
        }
    }
}
