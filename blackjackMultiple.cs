using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int jugador = 0;
            Console.WriteLine("ingrese el numero de jugadores, minimo 2, maximo 5");
           
            int n = int.Parse(Console.ReadLine()); ;
            //inicio validacion
            while (n < 2 && n > 5)
            {
                Console.WriteLine("ERROR, Los jugadores deben ser entre 2 y 5");
                n = int.Parse(Console.ReadLine());
            }
            string jugadorAnterior=null;
            string JugadorGanador = null;
            int puntuacion=0;
            while (jugador<n)
            {
                
                Console.WriteLine("Bienvenido, ingrese su nombre");
                JugadorGanador = Console.ReadLine();
                
                //inicio juego
                bool Eliminado = false;
                string DeseaContinuar = "no";
                int Carta1 = 0, valorMano = 0, Carta2 = 0, cartaNueva = 0;
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
                    Eliminado = true;
                }
                Console.WriteLine("Gracias por participar, su puntuacion fue: "+ valorMano);
                if (puntuacion < valorMano)
                {
                    jugadorAnterior = JugadorGanador;
                    puntuacion = valorMano;

                }
                
                jugador++;
            }
            Console.WriteLine("el ganador fue: " + jugadorAnterior);
          
        }
    }
}
