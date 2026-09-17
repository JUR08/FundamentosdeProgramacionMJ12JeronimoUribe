using System;

namespace Taller3Vectores3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            Escribir un algoritmo que permita:
            a.Llenar un vector[20] con números enteros(positivos o negativos) ingresados por el usuario o generados aleatoriamente.
            b.Calcular y mostrar el promedio aritmético de todos los elementos almacenados en el vector.
            c.Recorrer nuevamente el vector para contar e indicar cuántos números son mayores que el promedio y cuántos son menores que este. 
            d.Mostrar en pantalla el vector completo junto con los resultados obtenidos*/
            int[] vect = new int[20];
            int acum = 0;
            int prom = 0;
            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero para P{i + 1}:I{i} Del vector 1");
                vect[i] = int.Parse(Console.ReadLine());

                acum += vect[i];

            }
            prom = acum / vect.Length;
            for (int i = 0; i < vect.Length; i++)
            {
                Console.Write($"{vect[i]}, ");
            }
            Console.WriteLine("Es el vector completo");
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] > prom)
                {
                    Console.Write($"{vect[i]}, ");
                }

            }
            Console.WriteLine("Son los números mayores al promedio");
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] < prom)
                {
                    Console.Write($"{vect[i]}, ");
                }
            }
            Console.WriteLine("Son los números menores al promedio");
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] == prom)
                {
                     Console.Write($"{vect[i]}, ");
                }
            }
            Console.WriteLine("Son los números iguales al promedio");
        }
    }
}