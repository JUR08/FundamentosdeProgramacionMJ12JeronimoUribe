using System;

namespace X.Tallerpunto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;
            double x3 = 0;
            double y3 = 0;
            Console.WriteLine("Digite las coordenadas del primer punto");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite las coordenadas del segundo punto");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite las coordenadas del tercer punto");
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());

            double distp1p2 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double distp1p3 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double distp2p3 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));

            if (distp2p3 + distp1p3 > distp1p2)
            {
                Console.WriteLine("No es posible hacer un triangulo con estos puntos, la suma de la distacia del punto 2 al 3 y la del " +
                    "punto 1 al 3 no debe ser mayor que la distancia del punto 1 al 2");
            }
            else if (distp2p3 + distp1p2 > distp1p3)
            {
                Console.WriteLine("No es posible hacer un triangulo con estos puntos, la suma de la distacia del punto 2 al 3 y la del " +
                    "punto 1 al 2 no debe ser mayor que la distancia del punto 1 al 3");
            }
            else if (distp1p3 + distp1p2 > distp2p3)
            {
                Console.WriteLine("No es posible hacer un triangulo con estos puntos, la suma de la distacia del punto 1 al 3 y la del " +
                    "punto 1 al 2 no debe ser mayor que la distancia del punto 2 al 3");
            }
            else
            {
                Console.WriteLine("Estos puntos pueden crear un triangulo");
            }


        }
    }
}
