using System;


namespace _9.CicloWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde la cantidad de números que va a introducir. el algoritmo debe escribir
            La cantidad de números introducidos mayores a 0, menores a 0 e iguales a 0*/
            int acumulador = 0;
            int nums = 0;
            int numero = 0;
            int mayores = 0;
            int menores = 0;
            int ceros = 0;
            Console.WriteLine("Escriba la cantidad de números que desea escribir");
            nums = int.Parse(Console.ReadLine());
            while (acumulador < nums)
            {
                acumulador++;
                Console.WriteLine("Escriba números aleatorios");
                numero = int.Parse(Console.ReadLine());
                if (numero == 0)
                {
                    ceros++;
                }
                else if (numero < 0)
                {
                    menores++;
                }
                else if (numero > 0)
                {
                    mayores++;
                }

            }
            Console.WriteLine("La cantidad de números introducidos mayores a 0 es " + mayores + ", la cantida de números introducidos menores a 0 es " + menores + " Y la cantidad de 0 es de " + ceros);
        }
    }
}
