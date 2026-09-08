using System;

namespace Taller2Ciclos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular promedio de calificaciones, debe introducir tantas como desee, detectar cuando no desea continuar
            int calif = 0;
            string respuesta;
            int contcalif = 0;
            int contbucle = 0;
            int prom = 0;
            do
            {
                Console.WriteLine("Digite la calificación");
                calif = int.Parse(Console.ReadLine());
                Console.WriteLine("Desea continuar? si o no");
                respuesta = Console.ReadLine();
                contcalif += calif;
                contbucle++;
            } while (respuesta == "si");
            prom = (contcalif / contbucle);
            Console.WriteLine("El promedio de notas es de " + (prom));
        }
    }
}
