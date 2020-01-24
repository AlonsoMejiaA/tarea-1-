using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingresar los valores
            Console.WriteLine("escriba el valor de w");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("escriba el valor de t");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("escriba el valor de c");
            double c = double.Parse(Console.ReadLine());


            //operaciones

            double a = 90 - c;
            double SuperAuxiliar1 = Math.Cos(a * (Math.PI / 180));
            double z = (t * SuperAuxiliar1);
            double CatetoAuxiliar = Math.Sqrt(Math.Pow(w, 2) - Math.Pow(z, 2));
            double SuperAuxiliar2 = Math.Sin(a * (Math.PI / 180));
            double y = (t * SuperAuxiliar2);
            double x = CatetoAuxiliar - y;

            //mostrar en pantalla
            Console.WriteLine("El valor de x es: " + x);

        }
    }
}
