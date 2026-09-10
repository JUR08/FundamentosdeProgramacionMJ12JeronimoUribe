using System;
namespace Parcial_Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*           Doña Ana, la tendera del barrio, necesita un programa para calcular el valor total de una venta que consta de 10 productos.El programa debe aplicar un porcentaje de IVA 
                        a cada producto según su valor base ingresado, siguiendo estrictamente estas reglas:
               Estructura Repetitiva: Utiliza un ciclo para procesar exactamente los 10 productos de la venta.
               Ingreso y Reglas de IVA: Por cada producto, solicita su valor base por teclado y aplica el impuesto correspondiente:
                       Si el valor del producto es mayor a 10.000, se le aplica un 15 % de IVA.
                   Si el valor del producto está entre 5.000 y 10.000(inclusive), se le aplica un 17 % de IVA(Nota: condición ajustada para cubrir todo el rango).
                   Si el valor del producto es menor de 5.000, se le aplica un 19 % de IVA.
               Cálculos por iteración: Para cada producto, calcula su subtotal(valor base + valor del IVA correspondiente) y muéstralo en pantalla junto con el IVA aplicado.
               Acumulación y Cierre: A medida que avanza el ciclo, acumula los subtotales de los 10 productos.Al finalizar las 10 iteraciones, muestra en pantalla el valor total de la venta.*/
            int acumsubtot = 0;
            Console.WriteLine("Digite el valor de cada producto uno por uno");
            for (int contador = 1; contador <= 10; contador++)
            {
                int valor = int.Parse(Console.ReadLine());
                if (valor > 10000)
                {
                    int iva = (valor * 15) / 100;
                    int subtot = valor + iva;
                    Console.WriteLine("El producto de valor " + valor + " se le aplicó un iva de " + iva + " Quedando con precio de " + subtot);
                    acumsubtot += subtot;
                }
                else if (valor > 5000 && valor <= 10000)
                {
                    int iva = (valor * 17) / 100;
                    int subtot = valor + iva;
                    Console.WriteLine("El producto de valor " + valor + " se le aplicó un iva de " + iva + " Quedando con precio de " + subtot);
                    acumsubtot += subtot;
                }
                else
                {
                    int iva = (valor * 19) / 100;
                    int subtot = valor + iva;
                    Console.WriteLine("El producto de valor " + valor + " se le aplicó un iva de " + iva + " Quedando con precio de " + subtot);
                    acumsubtot += subtot;
                }
            }
            Console.WriteLine("El valor total de la venta es de " + acumsubtot);


        }
    }
}
