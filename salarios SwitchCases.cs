using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            Console.WriteLine("ingrese su salario: ");
            
            double SalarioMensual = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su tipo de contrato = 1: Dependiente 2: Independiente ");
            double TipoDeContrato = double.Parse(Console.ReadLine());
            double riesgo; 
            double SMMLV = 877803;
            double prima;
            double pension;
            double EPS;
            double ARL = 0;
            double deducciones;
            double BaseCotizacion = SalarioMensual * 0.4;
            double SalarioReal;
            double SalarioAnual;

            //respuesta
            switch (BaseCotizacion < SMMLV)
            {
                case true:
                    BaseCotizacion = SMMLV;
                    break;
                default:
                    break;

            }
                
            switch (TipoDeContrato)
            {
                case 2:
                    Console.WriteLine("Ingrese su nivel de riesgo laboral de 1 a 5");
                    riesgo = double.Parse(Console.ReadLine());
                    switch (riesgo)
                    {
                        case 1:
                            ARL = BaseCotizacion * 0.00522;
                            break;
                        case 2:
                            ARL = BaseCotizacion * 0.01044;
                            break;
                        case 3:
                            ARL = BaseCotizacion * 0.02436;
                            break;
                        case 4:
                            ARL = BaseCotizacion * 0.04350;
                            break;
                        default:
                            ARL = BaseCotizacion * 0.06960;
                            break;
                    }
                    EPS = BaseCotizacion * 0.125;
                    pension = (BaseCotizacion * 16)/100;
                    deducciones = ARL + pension + EPS;
                    SalarioReal = (SalarioMensual - deducciones);
                    SalarioAnual = SalarioReal * 12;
                    Console.WriteLine("Su salario real es: " + SalarioReal);
                    Console.WriteLine("Su salario anual es: " + SalarioAnual);
                    break;
                    
                default:
                    EPS = (BaseCotizacion * 4) / 100;
                    pension = (BaseCotizacion * 4) / 100;
                    prima = SalarioMensual;
                    deducciones = ARL + pension + EPS;
                    SalarioReal = (SalarioMensual - deducciones);
                    SalarioAnual = SalarioReal * 12 + prima;
                    Console.WriteLine("Su salario real es: " + SalarioReal);
                    Console.WriteLine("Su salario anual es: " + SalarioAnual);
                    break;
            }
        }
    }
}
