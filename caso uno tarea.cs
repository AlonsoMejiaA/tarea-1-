using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double CatetoA = 2.0;
            double CatetoB = 3.0;
            double AnguloRecto = 90.0;
            double Hipotenusa = Math.Sqrt((CatetoA * CatetoA) + (CatetoB * CatetoB));
            double anguloA = Math.Asin(CatetoB / Hipotenusa);
            double anguloC = (180 - anguloA - AnguloRecto);
            Console.Write("El cateto A ES: " + CatetoA + " El cateto B es: " + CatetoB + " La hipotenusa es: " + Hipotenusa +"los angulos son: "+ AnguloRecto + " " + anguloA + " " + anguloC);
           
        }
    }
}
