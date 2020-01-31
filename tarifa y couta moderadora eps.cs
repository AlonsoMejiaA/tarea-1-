using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar su salario
            Console.WriteLine("ingrese su salario diario");
            double salarioDelSujeto = double.Parse(Console.ReadLine());

            //Valor del SMMLV

            double SMLDV = 29260.10;

            //CONDICIONALES

            if (salarioDelSujeto < (2 * SMLDV))
            {
                double ValorTarifa1 = (salarioDelSujeto * 2) / 100;
                double CoutaModeradora = (SMLDV * 11.7) / 100;
                double total = ValorTarifa1 + CoutaModeradora;
                Console.WriteLine("su valor a pagar con su tarifa es: " + ValorTarifa1 + " y el valor de su cuota moderadora es :" + CoutaModeradora + " para un total de: " + total);
            }
            else if (salarioDelSujeto >= (2 * SMLDV) && salarioDelSujeto < (5 * SMLDV))
            {

                double ValorTarifa1 = (salarioDelSujeto * 5) / 100;
                double CoutaModeradora = (SMLDV * 46.1) / 100;
                double total = ValorTarifa1 + CoutaModeradora;
                Console.WriteLine("su valor a pagar con su tarifa es: " + ValorTarifa1 + " y el valor de su cuota moderadora es :" + CoutaModeradora + " para un total de: " + total);
            }
            else
            {
                double ValorTarifa1 = (salarioDelSujeto * 10) / 100;
                double CoutaModeradora = (SMLDV * 121.5) / 100;
                double total = ValorTarifa1 + CoutaModeradora;
                Console.WriteLine("su valor a pagar con su tarifa es: " + ValorTarifa1 + " y el valor de su cuota moderadora es :" + CoutaModeradora + " para un total de: " + total);
                
            }
        }
    }
}
