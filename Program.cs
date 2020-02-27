using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            //creaciòn de los arreglos
            double[] CoordsX = { 0, 2, 3, 7 };
            double[] CoordsY = { 0, 1, 5, 6 };
            //declaraciòn de variables
            Console.WriteLine(" desea calcular si pertnecen a la misma recta recta n/s");
            string deseo1 = Console.ReadLine();
            while (deseo1 == "s")
            {
                
                double pendiente1 = (CoordsY[1] - CoordsY[0]) / (CoordsX[1] - CoordsX[0]);
                double pendiente2 = (CoordsY[3] - CoordsY[2]) / (CoordsX[3] - CoordsX[2]);
                double pendiente3 = (CoordsY[3] - CoordsY[0]) / (CoordsX[3] - CoordsX[0]);
                double pendiente4 = (CoordsY[3] - CoordsY[1]) / (CoordsX[3] - CoordsX[1]);

                if (pendiente1 == pendiente2 && pendiente1 == pendiente3 && pendiente1 == pendiente4)
                {
                    Console.WriteLine("los puntos pertenecen a la misma recta");

                }
                else
                    Console.WriteLine("los puntos NO pertenecen a la misma recta");


                break;
            }
        
            while (true)
            {

                double distancia1 = Math.Sqrt(Math.Pow(CoordsX[1] - CoordsX[0], 2) + Math.Pow(CoordsY[1] - CoordsY[0], 2));
                double distancia2 = Math.Sqrt(Math.Pow(CoordsX[2] - CoordsX[0], 2) + Math.Pow(CoordsY[2] - CoordsY[0], 2));
                double distancia3 = Math.Sqrt(Math.Pow(CoordsX[3] - CoordsX[0], 2) + Math.Pow(CoordsY[3] - CoordsY[0], 2));
                double distancia4 = Math.Sqrt(Math.Pow(CoordsX[2] - CoordsX[1], 2) + Math.Pow(CoordsY[2] - CoordsY[1], 2));
                double distancia5 = Math.Sqrt(Math.Pow(CoordsX[3] - CoordsX[1], 2) + Math.Pow(CoordsY[3] - CoordsY[1], 2));
                double distancia6 = Math.Sqrt(Math.Pow(CoordsX[3] - CoordsX[2], 2) + Math.Pow(CoordsY[3] - CoordsY[2], 2));
                
                if (distancia1 > distancia2 && distancia1 > distancia3 && distancia1 > distancia4 && distancia1 > distancia5 && distancia1 > distancia6)
                {
                    Console.WriteLine("la distancia uno es la mayor");
                }
                else if (distancia2 > distancia1 && distancia2 > distancia3 && distancia2 > distancia4 && distancia2 > distancia5 && distancia2 > distancia6)
                {
                    Console.WriteLine("la distancia dos es la mayor");
                }
                else if (distancia3 > distancia2 && distancia3 > distancia1 && distancia3 > distancia4 && distancia3 > distancia5 && distancia3 > distancia6)
                {
                    Console.WriteLine("la distancia tres es la mayor");
                }
                else if (distancia4 > distancia2 && distancia4 > distancia3 && distancia4 > distancia1 && distancia4 > distancia5 && distancia4 > distancia6)
                {
                    Console.WriteLine("la distancia cuatro es la mayor");
                }
                else if (distancia5 > distancia2 && distancia5 > distancia3 && distancia5 > distancia4 && distancia5 > distancia1 && distancia5 > distancia6)
                {
                    Console.WriteLine("la distancia cinco es la mayor");
                }
                else
                {
                    Console.WriteLine("la distancia seis es la mayor");
                }
                break;
            }






        }
    }
}
