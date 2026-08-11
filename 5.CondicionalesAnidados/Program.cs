using System;


namespace _5.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Por favor ingrese los 3 valores diferentes");
            Console.WriteLine("Ingrese el valor del número 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 3");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            { 
                if (num1>num3)
            {
                Console.WriteLine("El número 1 es el mayor");
            }
                else
            {
                Console.WriteLine("El número 3 es el mayor");
            }
           }
            else
            {
                if (num2>num3)
                {
                    Console.WriteLine("El número 2 es el mayor");
                }
                else
                {
                    Console.WriteLine("El número 3 es el mayor");
                }
            }
        }
    }
}
