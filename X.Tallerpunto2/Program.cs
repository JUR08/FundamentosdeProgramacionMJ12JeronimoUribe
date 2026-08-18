using System;

namespace X.Tallerpunto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Random rnd = new Random();
            num = rnd.Next(1, 20);
            string check;
            Console.WriteLine(num);
            Console.WriteLine("true o false: el personaje es invencible");
            bool inv = bool.Parse(Console.ReadLine());
            if (inv == true && num >= 1 && num <= 10) {
                Console.WriteLine("El personaje esta disparando");
            }


        }
    }
}
