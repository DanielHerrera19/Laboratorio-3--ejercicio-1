using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3__ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipo de fruta");
            Console.WriteLine("0: naranja");
            Console.WriteLine("1: fresa");
            Console.WriteLine("2: mango");
            string frutatxt = Console.ReadLine();

            Console.Write("Ingrese la distancia: ");
            string distanciatxt = Console.ReadLine();

            float distancia = float.Parse(distanciatxt);
            int tipoFruta = int.Parse(frutatxt);
            float pago = 0f;

            switch (tipoFruta)
            {
                case 0:
                    if (distancia < 30)
                    {
                        pago = 2;
                    }
                    else
                    {
                        pago = 4;
                    }
                    break;
                case 1:
                    if (distancia < 30)
                    {
                        pago = 6;
                    }
                    else
                    {
                        pago = 9;
                    }
                    break;
                case 2:
                    if (distancia < 30)
                    {
                        pago = 3;
                    }
                    else
                    {
                        pago = 5;
                    }
                    break;
                default:
                    Console.WriteLine("Ingrese un tipo de fruta valido");
                    break;
            }
            Console.WriteLine("El pago es: " + pago);
            Console.ReadKey();
        }
    }
}
