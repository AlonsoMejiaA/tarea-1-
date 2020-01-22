using System;

namespace caso_3_tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            double AnguloRecto = 90.0;
            double AnguloC = 56.31;
            double CatetoB = 3.0;
            double CatetoA = CatetoB / Math.Tan(AnguloC);
            double Hipotenusa = Math.Sqrt((CatetoA * CatetoA) + (CatetoB * CatetoB));
            double AnguloA = Math.Atan(CatetoA / CatetoB);
            Console.Write("El cateto A ES: " + CatetoA + " El cateto B es: " + CatetoB + " La hipotenusa es: " + Hipotenusa + "los angulos son: " + AnguloRecto + " " + AnguloA + " " + AnguloC);
        }
    }
}
