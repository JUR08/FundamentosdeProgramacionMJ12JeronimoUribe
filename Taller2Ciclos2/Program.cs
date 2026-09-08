using System;
using System.Globalization;
using System.Security.Cryptography;

namespace Taller2Ciclos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se requiere un algoritmo para mostrar por pantalla los divisores de un
            número ingresado por teclado. 
            Tener en cuenta que dados dos números enteros a y b, se dice que b es
            divisor de a si se cumple que al efectuar una división entera a/ b el
            residuo es 0, en C# utilizar el operador Mod para obtener el residuo de 
            una división de dos números.
            Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3, 
            2, 1 que son los divisores del número 6.*/
            Console.WriteLine("Escriba un número");
            int num = int.Parse(Console.ReadLine());
            int cont = 0;
            Console.WriteLine("Los divisores de " + (num) + " son...");
            do
            {
                cont++;
                if (num % cont == 0)
                {
                    Console.WriteLine(cont);
                }
            } while (cont <= num);
        }
    }
}
