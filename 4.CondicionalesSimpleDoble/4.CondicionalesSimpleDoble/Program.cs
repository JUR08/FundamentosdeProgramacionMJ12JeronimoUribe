using System;
namespace _4.CondicionalesSimpleDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte edad = 0;
            Console.WriteLine("Digite su edad");
            edad = Convert.ToByte(Console.ReadLine());
              if (edad >= 18)
              {
                  Console.WriteLine("Bienvenido a mi sitio web");
              }
            else
            {
                Console.WriteLine("No es apto para el contenido de este sitio web");
            }

            //Crear un algoritmo que permita ingresar nombre y sueldo, si el sueldo es mas de 3k pesos mostrar mensaje en pantalla
            //con nombre de persona diciendo que debe abonar impuestos

/*            decimal sueldo = 0;
            string nombre;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo");
            sueldo = Convert.ToDecimal(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine(nombre + " usted debe abonar impuestos.");
            }*/



        }
    }
}
