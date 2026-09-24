using System;

namespace _17.ArreglosBidimensionales_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[,] La coma ya indica que sera bidimensional*//*
            int[,] numeros = new int[2, 3];

            //numeros[2,1] = 23 no se puede almacenar porque el índice de la fila no existe
            //numeros[1.3] = 54 no se puede almacenar porque el índice de la columna no existe
            numeros[0, 0] = 25;
            numeros[0, 1] = 41;
            numeros[0, 2] = 104;
            numeros[1, 0] = 47;
            numeros[1, 1] = 56;
            numeros[1, 2] = 6;

            Console.WriteLine($"El valor almacenado en numeros[1,1] es; {numeros[1, 1]}");

            //Recorrer para llenar
            char[,] simbolos = new char[3, 2];
            for (int i=0; i<3; i++) //Recorrer las filas
            {
                for(int j=0; j<2; j++) //Recorrer las columnas
                {
                    Console.WriteLine($"Ingrese el caracter para simbolos [{i}, {j}]");
                    simbolos[i, j] = char.Parse((Console.ReadLine()));
                }
            }
            //Recorrer para recuperar
            for (int i=0; i<simbolos.GetLength(0);i++)
            {
                for (int j=0; j<simbolos.GetLength(1); j++)
                {
                    //El getlength con 0 y 1 se refiere a la dimensión, un arreglo de 3 dimensiones necesitaria uno con un 2, solo usalo siempre así
                    Console.Write($"{simbolos[i, j]} ");
                }

            }
            //Otra forma de celarar e inicializar matrices
            string[,] nombres =
            {
                {"Ana", "Carlos", "Alex", "Mauricio"},
                {"Juan","Marta", "Maria", "Álvaro"},
                {"Ramiro", "Guillermo", "Cristian", "Blanca"}
            };*/


            //Crear una matriz[10, 20], en cada posición de la matriz poner el número 100, mostrar matriz
            /*          int[,] cien = new int[10, 20];
                      for (int i = 0; i < cien.GetLength(0); i++)
                      {
                          for (int j = 0; j < cien.GetLength(1); j++) 
                          {
                              cien[i, j] = 100;
                              Console.Write($"{cien[i, j]}, ");
                          }
                      }*/

            /*Escribir un programa que realice la suma de dos matrices de dimensiones 2x3
                -Solicita al usuario que ingrese los elementos de la primera y segunda matriz, calcular la matriz suma, resultado de sumar cada elemento en las matrices, mostrarla en formato de 2 filas, 3 columnas*/
            int[,] mat1 = new int[2, 3];
            int[,] mat2 = new int[2, 3];
            int[,] matsum = new int[2, 3];
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el número para Matriz 1 [{i}, {j}]");
                    mat1[i, j] = int.Parse((Console.ReadLine()));
                }
            }
          
            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el número para Matriz 2 [{i}, {j}]");
                    mat2[i, j] = int.Parse((Console.ReadLine()));
                    matsum[i, j] = mat1[i, j] + mat2[i, j];
                }

            }
            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    Console.Write($"{matsum[i, j]} | ");
                }
                Console.WriteLine(" ");

            }



        }
    }
}
