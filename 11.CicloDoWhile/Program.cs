using System;

namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Algoritmo que solicita un numero y genere su correspondiente tabla de multiplicar de 1 a 10 hasta que el usuario
             no desee generar tablas de multiplicar*/

            /*            int cont = 1;
                        int num = 0;
                        string respuesta;
                        do
                        {
                            Console.WriteLine("Digite un número del 1 al 10 para generar su tabla");
                            num = int.Parse(Console.ReadLine());
                            cont = 1;
                            do
                            {
                                Console.WriteLine((num) + " x " + (cont) + " = " + (num * cont));
                                cont++;
                            } while (cont <= 10);
                            Console.WriteLine("Desea continuar? si o no");
                            respuesta = Console.ReadLine();
                        } while (respuesta == "si");*/

            //Algoritmo que calcule y muestre en pantalla los numeros primos hasta el 100

            int num = 1;
            do
            {
                int divisor = 2;
                int cantdivisor = 0;
                do
                {
                    if (num % divisor == 0)
                    {
                        cantdivisor++;
                    }
                } while (divisor <= num);
                if (cantdivisor == 2)
                {
                    Console.WriteLine(num);
                }
                num++;

            } while (num <= 100);
           

        }
    }
}
