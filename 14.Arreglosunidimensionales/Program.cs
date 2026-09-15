using System;
using System.Diagnostics;
using System.Linq;

namespace _14.Arreglosunidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //Arreglos Unidimensionales - Vectores
             int[] numeros = new int[5];

             numeros[0] = 10;
             // numeros 
             //0 -- 10
             //1 --
             //2 --
             //3 -- 
             //4 --
             //5 --
             //Les va a asignar un valor a cada uno
             numeros[1] = 56;
             numeros[2] = 22;
             numeros[3] = 45;
             numeros[4] = 102;
             //numeros[5] = 14;
             // esto no se puede porque el new int[5] indica 5 posiciones, ya ocupadas por 0, 1, 2, 3, 4, esta fuera del rango

             Console.WriteLine($"El número almacenado en la posición 3 con índice 2 es: {numeros[2]}");
             //Otras formas de declarar e inicializar vectores
             char[] símbolos = new char[] { '#', '&', 'ó', '0', 'a' };
             bool[] valoresVerdad = { true, false, false, true, true, false, false };

             //Recorrer para almacenar datos
             string[] nombres = new string[7];
             for (int i = 0; i < 7; i++)
             {
                 Console.WriteLine($"Ingrese el nombre para P{i + 1}:I{i}"); //P - Posición, I -Índice
                 nombres[i] = Console.ReadLine();
             }
             Console.Clear(); //Esto limpia la consola, borra lo que estaba en pantalla
             //Recorrer para recuperar
             for (int i = 0; i<nombres.Length; i++)  //i<nombres.Length en este caso me devuelve 7, es el rango del vector
             {
                 Console.Write($"{nombres[i]} |");
             }*/





            //Crear arreglo llamado "numeros" de 100 elementos, asginar el número 10 en cada una de las posiciones del arreglo.
            //Leer el contenido y mostrarlo en pantalla
            /*            int[] numeros = new int[100];
                        for (int i = 0; i < numeros.Length; i++)
                        {
                            numeros[i] = 10;
                            Console.WriteLine(numeros[i]);
                        }*/



            //Algoritmo que permita solicitar 10 números, los cuales serán almacenados en un arreglo, al final, debe visualizar
            //el promedio de esos números
            int[] nums = new int[10];
            int cont = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingrese el numero para P{i + 1}:I{i}"); 
                nums[i] = int.Parse(Console.ReadLine());
                cont += nums[i];
                int prom = cont / 10;
                Console.Write(cont);
            }
            
        }
    }
}
