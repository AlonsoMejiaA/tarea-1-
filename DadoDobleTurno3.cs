using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variable
            Random valorDado = new Random();

            int dadoDefault = 0, dadoExtra = 0, turnos = 0, vidas = 3,Fantasma= 0, puntuacion=0;
            string deseaJugar = "n";
            //Inicio del juego
            Console.WriteLine("¿Bienvenido, desea jugar? s/n");
            deseaJugar = Console.ReadLine();
            while(deseaJugar== "s")
            {
                    turnos++;
                    dadoDefault = valorDado.Next(1, 7);
                //dadoDefault = 6;

                while (Fantasma < 3)
                    {
                        Fantasma++;
                        dadoExtra = 0;
                        break;
                    }
                if (Fantasma == 3)
                    {
                    dadoExtra = valorDado.Next(1, 7);
                   // dadoExtra = 6;
                    Console.WriteLine("TURNO DE DOBLE DADO!!, este tiene valor de: " + dadoExtra);
                    Fantasma = 0;
                    }
                while (turnos % 2 == 0)
                    {
                        vidas--;
                        break;
                    }
                if (dadoDefault == dadoExtra)
                    {
                        vidas++;
                    Console.WriteLine("DADOS IGUALES, GANAS UNA VIDA!!");
                    
                }
                puntuacion += (dadoDefault + dadoExtra);
                Console.WriteLine("El valor del dado fue: " + dadoDefault + " su puntuaciòn es: " + puntuacion);
                Console.WriteLine("Tienes " + vidas + " vidas");
                if (vidas == 0)
                {
                    Console.WriteLine("HAS PERDIDO, TU PUNTUACIÒN FUE" + puntuacion);
                    deseaJugar = "N";
                    break;

                }
                if (puntuacion >= 100)
                {
                    Console.WriteLine("HAS GANADO, TU PUNTUACIÒN FUE: " + puntuacion);
                    deseaJugar = "N";
                    break;

                }
                Console.WriteLine("¿desea seguir jugando? s/n");
                deseaJugar = Console.ReadLine();
            }

            
        }
    }
}
