using System;

namespace _2.ConstanteTiposDOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string gravedad = "9.8";
            string nombre = "Bob";
            nombre = "Esponja";
            //gravedad = "10"; no puedo cambiar el valor de una constante

            //tipos de datos
            byte dato1 = 0;
            int dato2 = -4563;
            ulong dato3 = 32496743967432967;
            float dato4 = 14.6f;
            double dato5 = 45970849.597039;
            decimal dato6 = 4256954628452968.45269654927854m;

            char dato7 = 'A';
            string dato8 = "fwfhowfhoiwi";
            bool dato9 = false;
            object dato10 = new object();

            //OPERADORES
            //Operadores numericos
            //Cambio de signo
            int dato11 = 5;
            int dato12 = -dato11;
            int dato13 = +dato12;
            int dato14 = -dato13;
            Console.WriteLine("dato11:{0}, dato12:{1}, dato13:{2}, dato14:{3}", dato11, dato12, dato13, dato14);
            int dato15 = 5 + 3;//suma
            int dato16 = dato15 - 2;//resta
            int dato17 = 25 * 3;//producto
            float dato18 = (float)5 / 3; //Division, podria alternativamente ponerle f al 5, al 3 o a los dos
            Console.WriteLine("Suma:{0}, Resta:{1}, Producto; {2}, División;{3}" ,dato15, dato16, dato17, dato18);

        }
    }
}
