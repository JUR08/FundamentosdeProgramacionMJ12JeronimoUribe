using System;

namespace Parcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su género (escriba mujer u hombre)");
            string gen = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            byte age = byte.Parse(Console.ReadLine());
            string ing = "x";
            if (age == 15)
            {
                Console.WriteLine("¿Usted domina el inglés? si o no");
                ing = Console.ReadLine();
            }
            Console.WriteLine("Ingrese su último digito de su documento de identidad");
            byte doc = byte.Parse(Console.ReadLine());
            if (doc > 9)
            {
                Console.WriteLine("Por favor escriba solo el último dígito");
            }

            if (age >= 16 && age <= 20 && gen == "mujer" && (doc == 0 || doc == 4 || doc == 8) || gen == "hombre" && age >= 18 && age <= 22 && (doc == 2 || doc == 6))
            {
                Console.WriteLine("Usted pertenece al Grupo A");
            }
            else if (age >= 21 && age <= 25 && gen == "mujer" && (doc == 3 || doc == 7) || gen == "hombre" && age >= 23 && age <= 26 && (doc == 2 || doc == 6))
            {
                Console.WriteLine("Usted pertenece al Grupo B");
            }
            else if (ing == "si" && age == 15)
            {
                Console.WriteLine("Usted pertenece al Grupo C");
            }
            else
            {
                Console.WriteLine("Usted pertenece al Grupo D");
            }



        }
    }
}
