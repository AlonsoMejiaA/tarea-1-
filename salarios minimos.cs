using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar su salario
            Console.WriteLine("ingrese su salario");
            double salarioDelSujeto = double.Parse(Console.ReadLine());

            //Valor del SMMLV

            double SMMLV = 877803.00;

            //CONDICIONALES

            if (salarioDelSujeto < (2 * SMMLV))
            {
                double ValorTarifa1 = (salarioDelSujeto * 2) / 100;
                Console.WriteLine("su valor a pagar con su tarifa es: " + ValorTarifa1);
            }
            else if (salarioDelSujeto >= (2*SMMLV) && salarioDelSujeto < (4*SMMLV)) {

                double ValorTarifa1 = (salarioDelSujeto * 5) / 100;
                Console.WriteLine("su valor a pagar con su tarifa es: " + ValorTarifa1);
            }
            else{
                double ValorTarifa1 = (salarioDelSujeto * 10) / 100;
                Console.WriteLine("su valor a pagar con su tarifa es: " + ValorTarifa1);
            }

        }
    }
}
