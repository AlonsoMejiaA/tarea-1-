using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Eliminado = false;
            string DeseaContinuar = "no";
            int Carta1 = 0, valorMano = 0,Carta2 = 0, cartaNueva = 0;
            Random Suerte = new Random();

            while (Eliminado == false)
            {
                Carta1 = Suerte.Next(1, 10);
                Carta2 = Suerte.Next(1, 10);
                valorMano = Carta1 + Carta2 + cartaNueva;
                Console.Write("el valor de su mano es: " + valorMano);
                Console.WriteLine("Desea continuar? si/no");
                DeseaContinuar = Console.ReadLine();
                while (DeseaContinuar == "si")
                {
                    cartaNueva = Suerte.Next(1, 10);
                    valorMano += cartaNueva;
                    if (valorMano > 21)
                    {
                        Eliminado = true;
                        DeseaContinuar = "no";
                        Console.Write("usted ha sido eliminado");
                    }
                    else
                    {
                        Console.Write("el valor de su mano es: " + valorMano);
                        Console.Write("Desea continuar? si/no");
                        DeseaContinuar = Console.ReadLine();
                    }
                }

            }
        }
    }
}
