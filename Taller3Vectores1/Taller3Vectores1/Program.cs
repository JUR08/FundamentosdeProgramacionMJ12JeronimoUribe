using System;

namespace Taller3Vectores1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego
encuentre y muestre el valor máximo y mínimo de los números ingresados. */
            int[] numeros = new int[15];
            int max = numeros[0];
            int min = numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero para P{i + 1}:I{i}"); 
                 numeros[i] = int.Parse(Console.ReadLine());

                if (i==0)
                {
                    min = numeros[0];
                    max = numeros[0];
                }

                    if (numeros[i] > max)
                    {
                        max = numeros[i];
                    }
                    if (numeros[i] < min)
                    {
                        min = numeros[i];
                    }
                
            }
            Console.WriteLine($"El máximo de los numeros ingresados es {max} y el mínimo es {min}");

        }
    }
}
