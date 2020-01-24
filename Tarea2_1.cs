using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingresar los valores
            Console.WriteLine("escriba el valor de b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("escriba el valor de z");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("escriba el valor de y");
            double y = double.Parse(Console.ReadLine());

            
            //operaciones
            double t = Math.Sqrt((Math.Pow(y, 2)) + (Math.Pow(z, 2)));
            double c = (Math.Asin(z / t)) * (180/Math.PI);
            double a = 90.0 - c;
            double e = 180.0 - c;
            double d = (180.0 - e - b);
            double SuperAuxiliar = Math.Tan(d * (Math.PI/180));
            double catetoAuxiliar = (z / SuperAuxiliar);
            double x = catetoAuxiliar - y;
            double w = Math.Sqrt((Math.Pow(catetoAuxiliar, 2)) + (Math.Pow(z, 2)));

            //Mostrar respuesta en pantalla
            Console.WriteLine("De el triangulo preguntado el valor de sus lados son: w: " + w + " t: " + t + " x: " + x);
            Console.WriteLine("De el triangulo preguntado el valor de sus angulos son: d: " + d + " e: " + e + " b: " + b);
           

        }
    }
}
