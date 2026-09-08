using System;
namespace Taller2Ciclos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            Dados dos números enteros ingresados por teclado: b que es la base y
                          e que es el exponente, se requiere calcular el resultado de la
                          potenciación.
                          Ejemplo: b = 2, e = 5  25 = 2 * 2 * 2 * 2 * 2 = 32
                          Mostrar por pantalla el resultado de la potenciación. 
                          Seguir pidiendo por teclado la base y el exponente y realizar la
                          potenciación correspondiente, hasta que el usuario ingrese por teclado
                          el carácter de escape ‘n’ */
            string resp;
            do
            {


                Console.WriteLine("Ingrese una base");
                int bas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un exponente");
                int exp = int.Parse(Console.ReadLine());
                int cont = 0;
                int pot = 1;
                do
                {
                    cont++;
                    pot *= bas;

                } while (cont < exp);
                Console.WriteLine(pot);
                Console.WriteLine("Desea continuar?");
                Console.WriteLine("Si = s                                      No = n");
                resp = Console.ReadLine();
            } while (resp == "s");
 
        }
    }
}
