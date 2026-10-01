using System;

namespace _18.Programaciónmodular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso");
            MostrarMensaje("Jerónimo");
            Console.WriteLine($"Jerónimo tiene {CalcularEdad()} ");
            MostrarMensaje("Hector");
            MostrarMensaje("Alex", "Nicolas");
            Console.WriteLine($"Alex tiene {CalcularEdad(2026, 2008)} ");
            Console.ReadKey();
            BorrarPantalla();
        }

        //Funciones con parámetros

        static int CalcularEdad(int añoActual, int añoNacimiento)
        {
            return añoActual - añoNacimiento;
        }
        //Funciones sin parametros
        static int CalcularEdad()
        {
            int añoNacimiento = 2008;
            int añoActual = 2026;
            int edad = añoActual - añoNacimiento;
            return edad;
        }

        //Procedimientos sin parámetros
        static void BorrarPantalla()
        {
            Console.Clear();
        }
        //Procedimientos con parámetros
        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido, {nombre} al curso de fundamentos de programación");
        }
        static void MostrarMensaje(string nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenido, {nombre} {apellidos} al curso de fundamentos de programación");
        }
    }
}

