using System;

namespace Taller3Vectores1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2.Escribir un algoritmo que permita: 
a.Crear dos vectores del mismo tamaño. 
b.Llenarlos con números.
c.Comparar posición por posición.
d.Indicar cuántos elementos son iguales. */
            int[] numuno = new int[15];
            int[] numdos = new int[15];
            for (int i = 0; i < numuno.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero para P{i + 1}:I{i} Del vector 1");
                numuno[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(numuno[i]);

            }
            Console.Clear();
            for (int i = 0; i < numdos.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero para P{i + 1}:I{i} Del vector 2");
                numdos[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(numdos[i]);
                if (numuno[i] == numdos[i])
                {
                    Console.WriteLine($"Los numeros de la  P{i + 1}:I{i} son iguales");
                }

            }
        }
    }
}