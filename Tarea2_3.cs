using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingresar los valores
            Console.WriteLine("escriba el valor de w");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("escriba el valor de d");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("escriba el valor de x");
            double x = double.Parse(Console.ReadLine());


            //operaciones

            double AnguloAuxiliar = 90.0 - d;
            double SuperAuxiliar = Math.Sin(AnguloAuxiliar * (Math.PI / 180));
            double CatetoAuxiliar = w * SuperAuxiliar;
            double y = CatetoAuxiliar - x;

            //mostrar en pantalla
            Console.WriteLine("El valor de y es: " + y);

        }
    }
}
