using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaraciòn de variables
            Random valorDado = new Random();
            int dado = 0, numeroTurnos = 1, puntuaciòn=0;
            
            bool fueDiez = false;
            string deseaContinuar = "n";
            //comienzo del juego
            Console.WriteLine("deseajugar 's' si no, 'n'");
            deseaContinuar = Console.ReadLine();
            while (deseaContinuar == "s" && numeroTurnos <= 3){
                dado = valorDado.Next(10, 13);
                puntuaciòn += dado;
                numeroTurnos++;
                if (dado == 10)
                {
                    fueDiez = true;
                    Console.WriteLine("el dado obtuvo: " + dado + " su puntuacion es: " + puntuaciòn);
                    Console.WriteLine("si desea seguir jugando 's' si no, 'n'");
                    deseaContinuar = Console.ReadLine();

                }
                else if (fueDiez && dado == 12)
                {
                    Console.WriteLine("el dado obtuvo: " + dado);
                    Console.WriteLine("obtuvo un 10 y luego un 12");
                    Console.WriteLine("Usted ha GANADO");
                    deseaContinuar = "n";
                }
                else
                {
                    Console.WriteLine("el dado obtuvo: " + dado + " su puntuacion es: " + puntuaciòn);
                    Console.WriteLine("si desea seguir jugando 's' si no, 'n'");
                    deseaContinuar = Console.ReadLine();
                }
                
                
                
            }
            while(deseaContinuar=="s" && numeroTurnos > 3){
                dado = valorDado.Next(1, 13);
                
                puntuaciòn += dado;
                numeroTurnos++;
                if (dado %2 == 0) {
                    if(dado == 10){
                        fueDiez = true;
                        Console.WriteLine("el dado obtuvo: " + dado + " su puntuacion es: " + puntuaciòn);
                        Console.WriteLine("si desea seguir jugando 's' si no, 'n'");
                        deseaContinuar = Console.ReadLine();

                    }
                    else if (fueDiez && dado == 12)
                    {
                        Console.WriteLine("el dado obtuvo: " + dado);
                        Console.WriteLine("obtuvo un 10 y luego un 12");
                        Console.WriteLine("Usted ha GANADO");
                        deseaContinuar = "n";
                    }
                    else if (puntuaciòn >= 100)
                    {
                        fueDiez = false;
                        Console.WriteLine("el dado obtuvo: " + dado + " su puntuacion es: " + puntuaciòn);
                        Console.WriteLine("obtuvo mas de 100 puntos");
                        Console.WriteLine("Usted ha GANADO");
                        deseaContinuar = "n";
                    }
                    else
                    {
                        fueDiez = false;
                        Console.WriteLine("el dado obtuvo: " + dado + " su puntuacion es: " + puntuaciòn);
                        Console.WriteLine("si desea seguir jugando 's' si no, 'n'");
                        deseaContinuar = Console.ReadLine();
                    }

                }
                else
                {
                    Console.WriteLine("el dado obtuvo: " + dado);
                    Console.WriteLine("Usted obtuvo un numero impar, ha PERDIDO");
                    Console.WriteLine(" su puntuacion fue: " + puntuaciòn);
                    deseaContinuar = "n";
                }
              
            }

        }
    }
}
