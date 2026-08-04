using System;
namespace _3.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores numéricos
            //Incremento decremento
            int dato1 = 0;
            dato1++;//dato1 = dato1 + 1; Incremento en 1 unidad
            dato1--;//dato1 = dato1 - 1; Decremento en 1 unidad
            dato1 += 15; //dato1=dato1+15;
            dato1 -= 14; //dato1=dato1-14;
            dato1 *= 3; //dato1=dato1*3;
            dato1 /= 2; //dato1=dato1/2;
            dato1 *= dato1; //dato1=dato1*dato1. Se puede hacer con cualquier operación y entre cualquier variable

            //Orden de evaluación de operadores aritméticos
            int dato2 = 4 * 3 / 2;
            int dato3 = 5 / 2 * 4;
            int dato4 = 4 * (5 / 2);
            int dato5 = 3 - 1 * (4 / 2);
            Console.WriteLine(dato2);
            //CONJUCIÓN -- AND -- Y -- &&
            Console.WriteLine("TABLA DE LA CONJUCIÓN");
            Console.WriteLine("V && V =" + (true && true));
            Console.WriteLine("V && F =" + (true && false));
            Console.WriteLine("F && V =" + (false && true));
            Console.WriteLine("F && F =" + (false && false));

            //DISYUNCIÓN -- OR -- O -- ||
            Console.WriteLine("TABLA DE LA CONJUCIÓN");
            Console.WriteLine("V || V =" + (true || true));
            Console.WriteLine("V || F =" + (true || false));
            Console.WriteLine("F || V =" + (false || true));
            Console.WriteLine("F || F =" + (false || false));

            //NEGACIÓN
            bool dato6 = true;
            bool dato7 = !dato6;

            //OPERADORES DE COMPARACIÓN
            bool dato8 = 5 > 4;
            bool dato9 = 1002 == 102;
            bool dato10 = 10 >= 9;
            bool dato11 = 0 != 1;
            bool dato12 = 4 < 5 && 3 == 0;
            bool dato13 = 0 != 2 && dato8 || dato9;


        }
    }
}
