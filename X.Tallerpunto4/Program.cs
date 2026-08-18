using System;

namespace X.Tallerpunto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pulse la D para que el personaje vaya a la derecha o I para ir a la izquierda");
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.D)
            {
                Console.WriteLine(": El personaje se mueve a la derecha");
            }
            else if (tecla.Key == ConsoleKey.I)
            {
                Console.WriteLine(": El personaje se mueve a la izquierda");
            }
            else
            {
                Console.WriteLine(": No me puedo mover en esa dirección");
            }
        }
    }
}
