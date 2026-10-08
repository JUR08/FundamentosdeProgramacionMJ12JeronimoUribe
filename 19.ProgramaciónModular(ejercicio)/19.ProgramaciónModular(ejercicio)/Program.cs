using System;

namespace _19.ProgramaciónModular_ejercicio_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            RealizarOperaciones(CapturarOpcion());
        }

        static void MostrarMenu()
        {
            Console.WriteLine("---------------------MENÚ--------------------");
            Console.WriteLine("1. Suma                       2. Resta");
            Console.WriteLine("3. Multiplicacióm             4. División");
            Console.WriteLine("                  0. Salir               ");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Ingrese una opción del menú:");
        }
        static int CapturarOpcion()
        {
            return int.Parse(Console.ReadLine());
        }
        static void RealizarOperaciones(int opcion)
        {
            while (opcion != 0)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"La suma de los números ingresados es: {Suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"La resta de los números ingresados es: {Resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"La multiplicación de los números ingresados es {Multiplicacion()}");
                        break;
                    case 4:
                        Console.WriteLine($"La divisíon de los números ingresados es {Division()}");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                MostrarMenu();
                opcion = CapturarOpcion();
            }
            
        }
        static float Suma()
        {
            float numero = 0;
            float suma = 0;
            char respuesta = ' ';
            do
            {
                Console.WriteLine("Ingrese un número");
                numero = float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("¿Desea sumar mas números?");
                Console.WriteLine("s para comtinuar");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return suma;
        }
        static float Multiplicacion()
        {
            float numero = 0;
            float producto = 1;
            char respuesta = ' ';
            do
            {
                Console.WriteLine("Ingrese un número");
                numero = float.Parse(Console.ReadLine());
                producto *= numero;
                Console.WriteLine("¿Desea Multiplicar mas números?");
                Console.WriteLine("s para comtinuar");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return producto;
        }
        static float Resta()
        {
            Console.WriteLine("Ingrese el número 1");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2");
            float num2 = float.Parse(Console.ReadLine());
            return num1 - num2; //El ejercicio restringia que la resta solo podia ser entre dos números 
        }
        static float Division()
        {
            Console.WriteLine("Ingrese el número 1");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2");
            float num2 = float.Parse(Console.ReadLine());
            return num1 / num2; //El ejercicio restringia que la división solo podia ser entre dos números 
        }

    }
}
