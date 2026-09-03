using System;

namespace _12.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo, para cada usuario hacer lo siguiente:
                            -Si el saldo es mayor o igual a 3M sacar un mensaje que diga el nombre del usuario, numero de cuenta y saldo y "Es apto para el credito"
                            -Si es menor a 3M, lo mismo pero con No es apto
                            El algoritmo debe permitir preguntar la informacion de usuarios hasta que se le indique que ya no pregunte, ademas, mostrar el numero de usuarios a los que se le pregunto la informacion y mostrar
                            promedio de salarios*/

            string nombre;
            int cuenta;
            int saldo;
            string respuesta;
            int contsaldos = 0;
            int contbucle = 0;
            int prom = 0;
                do
                {
                Console.WriteLine("Digite su nombre");
                nombre = (Console.ReadLine());
                Console.WriteLine("Digite su número de cuenta");
                cuenta = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite su saldo");
                saldo = int.Parse(Console.ReadLine());
                    
                    if (saldo < 3000000)
                    {
                        Console.WriteLine((nombre) + ", " + (cuenta) + ", " + (saldo) + ", No es apto para crédito");
                    }
                    else
                    {
                        Console.WriteLine((nombre) + ", " + (cuenta) + ", " + (saldo) + ", Es apto para crédito");
                    }
                          Console.WriteLine("Desea continuar? si o no");
                          respuesta = Console.ReadLine();
                             contsaldos += saldo;
                             contbucle++;
                 } while (respuesta == "si");
            prom = (contsaldos / contbucle);
            Console.WriteLine("El promedio de salarios es de " + (prom) + " Después de preguntarle a " + (contbucle)+ " usuarios");

        }
    }
}
