using System;

namespace Taller4Matrices2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar un programa que crea una matriz de n filas *m columnas, el usuario ingresa
caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la
primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la
matriz con el intercambio de filas.*/
            Console.WriteLine("Ingrese el número de filas de la matriz:");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de columnas de la matriz:");
            int columnas = int.Parse(Console.ReadLine());

            char[,] mat = new char[filas, columnas];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"Ingrese el valor para la posición [{i}, {j}]: ");
                    mat[i, j] = char.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz original:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(" | " + mat[i, j] + " | ");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                char matinv = mat[0, j];
                mat[0, j] = mat[filas - 1, j];
                mat[filas - 1, j] = matinv;
            }

            Console.WriteLine("Matriz con filas intercambiadas:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(" | " + mat[i, j] + " | ");
                }
                Console.WriteLine();
            }




        }
    }
}