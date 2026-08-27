using System;

namespace _8.CicloWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números negativos 
            //Variable bandera: que puede cambiar de estado
            //Contador: variable numérica que aumenta o disminuye su valor en una cantidad fija (constante) cada vez que ocurre un evento o se repite un proceso
            //Acumulador: variable numérica que aumenta o disminuye su valor en una cantidad fija (constante) cada vez que ocurre un evento o se repite un proceso

            int sumaEntero = 0; //el acumulador
            int numero = 0;
            Console.WriteLine("Ingrese un número para sumar");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0) //Esta es la variable bandera
            {
                sumaEntero += numero; //Le va sumando a la suma de entero el numero
                Console.WriteLine("Ingrese un número para sumar");
                numero = int.Parse(Console.ReadLine()); //Para que se digiten tantos numeros como sean necesarios hasta que aparezca uno negativo
            }
            Console.WriteLine("La suma de los números ingresados es: " + sumaEntero);
        }
    }
}
