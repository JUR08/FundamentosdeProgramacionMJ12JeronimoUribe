using System;

namespace _10.CicloWhile4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que cuente números pares de rango 1 a n
            int contador = 1;
            int num = 0;
            int par = 0;
            Console.WriteLine("Ingrese un número");
            num = int.Parse(Console.ReadLine());
            while (contador < num)
            {
                contador++;
                    if (contador % 2 == 0)
                {
                    par++;
                }
            }
            Console.WriteLine("La cantidad de pares del 1 al " + num + " es de " + par);
        }
    }
}
