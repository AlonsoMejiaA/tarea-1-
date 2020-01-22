using System;

namespace caso_2_tarea
{
    class Program
    {
        static void Main(string[] args)
        {
             double Hipotenusa = 3.61;
             double AnguloA = 33.69;
             double AnguloRecto = 90.0;
             double CatetoA = Hipotenusa * Math.Sin(AnguloA);
             double AnguloC = (180.0 - AnguloRecto - AnguloA);
             double CatetoB = Math.Sqrt((Hipotenusa * Hipotenusa) - (CatetoA * CatetoA));
            Console.Write("El cateto A ES: " + CatetoA + " El cateto B es: " + CatetoB + " La hipotenusa es: " + Hipotenusa + "los angulos son: " + AnguloRecto + " " + AnguloA + " " + AnguloC);


        }
    }
}
