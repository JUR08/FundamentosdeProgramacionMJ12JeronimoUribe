using System;

namespace _7.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////algoritmo que permite generar los primeros 5 numeros enteros positivos y realizar y mostrar su suma
            //      int contador = 1;
            //      int acumulador = 1;

            //      while (contador < 5)
            //      {
            //          contador++;
            //          acumulador = acumulador + contador;
            //      }

            //      Console.WriteLine("La suma de los cinco primeros números es: " + acumulador);
            //      
            //Algoritmo que permita calcular factorial de un número dado por el usuario
            Console.WriteLine("Digite un número");
            int num = int.Parse(Console.ReadLine());
            int cont = 1;
            int acum = 1;
            while (cont < num)
            {
                cont++;
                acum = acum * cont;
            }
            Console.WriteLine("El factorial de " + num + " es " + acum);
        }
    }
}
