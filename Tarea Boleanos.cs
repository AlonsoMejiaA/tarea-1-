using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese votos para el partido 1");
            double numeroVotos1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese votos para el partido 2");
            double numeroVotos2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese votos en blanco");
            double numeroVotosB = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese votos anulados");
            double numeroVotosA = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total de poblaciòn");
            double numeroTotalPoblacion = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese porcentaje de mayores de edad");
            double porcentajeMayoresDeEdad = double.Parse(Console.ReadLine());
            double votantes = numeroTotalPoblacion * (porcentajeMayoresDeEdad / 100);
            double totalVotos = numeroVotos1 + numeroVotos2 + numeroVotosA + numeroVotosB;
            bool A = totalVotos > numeroTotalPoblacion;
            bool B = (numeroVotos1 - numeroVotos2) < (totalVotos * 0.1);
            bool C = votantes < (numeroTotalPoblacion * 0.3);
            bool Par1 = numeroVotos1 > numeroVotos2;
            
            //realizaciòn
            if ((A || B) && C) 
                Console.WriteLine("Los votos no son validos, se deben repetir las eleciones");
            else if (Par1) Console.WriteLine(" El partido 1 es el ganador");
            else Console.WriteLine("El partido 2 es el ganador");

        }
    }
}
