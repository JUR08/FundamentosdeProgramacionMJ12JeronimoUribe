using System;

namespace _13.CicloFor
{
    internal class Program
    {
        static 
            void Main(string[] args)
        {
            /*           int acumulador = 0;

                       for (int contador = 1; contador <= 5; contador++) 
                       {
                           acumulador += contador;
                       }
                       Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");*/
            //Algoritmo que pida numero y calcule factorial
            Console.WriteLine("Digite un número");
            int num = int.Parse(Console.ReadLine());
            int fac = 1;
        
            for (int contador = 1; contador <= num; contador++)
            {
                fac *= contador;
            }
            Console.WriteLine("El factorial de " + (num) + " es " + (fac));
        }
    }
}
