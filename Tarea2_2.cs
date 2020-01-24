using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingresar los valores
            Console.WriteLine("escriba el valor de b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("escriba el valor de d");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("escriba el valor de y");
            double y = double.Parse(Console.ReadLine());


            //operaciones
            
            double e = 180.0 - d - b;
            double c = 180 - e;
            double a = 90.0 - c;
            double SuperAuxiliar = Math.Tan(c * (Math.PI / 180));
            double z = (y * SuperAuxiliar);
           

            //Mostrar respuesta en pantalla
            Console.WriteLine("el valor de z es: " + z); 
            
        }
    }
}
