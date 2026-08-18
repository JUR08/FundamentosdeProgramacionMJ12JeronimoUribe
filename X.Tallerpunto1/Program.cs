 using System;

namespace X.Tallerpunto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Digite tres números diferentes");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            if (num1 == num2 || num2 == num3 || num1 == num3) {
                Console.WriteLine("Por favor que los números sean diferentes");
            }
            else if (num1 > num2 && num1 > num3 && num2 > num3)
            {
                Console.WriteLine("El mayor numero es " + num1 + " y en orden de mayor a menor son: " + num1 + " " + num2 + " y " + num3);
            }
            else if (num1 > num2 && num1 > num3 && num3 > num2)
            {
                Console.WriteLine("El mayor numero es " + num1 + " y en orden de mayor a menor son: " + num1 + " " + num3 + " y " + num2);
            }
            else if (num2 > num1 && num2 > num3 && num1 > num3)
            {
                Console.WriteLine("El mayor numero es " + num2 + " y en orden de mayor a menor son: " + num2 + " " + num1 + " y " + num3);
            }
            else if (num2 > num1 && num2 > num3 && num3 > num1)
            {
                Console.WriteLine("El mayor numero es " + num2 + " y en orden de mayor a menor son: " + num2 + " " + num3 + " y " + num1);
            }
            else if (num3 > num2 && num3 > num1 && num1 > num2)
            {
                Console.WriteLine("El mayor numero es " + num3 + " y en orden de mayor a menor son: " + num3 + " " + num1 + " y " + num2);
            }
            else if (num3 > num2 && num3 > num1 && num2 > num1)
            {
                Console.WriteLine("El mayor numero es " + num3 + " y en orden de mayor a menor son: " + num3 + " " + num2 + " y " + num1);
            }
        }
    }
}
