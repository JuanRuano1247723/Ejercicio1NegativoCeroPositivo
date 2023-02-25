using System;

namespace Ejercicio1NegativoCeroPositivo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ejercicio 1: número entero, cero o negativo");
        inicio:
            Console.WriteLine("Escriba un número entero: ");
            bool convertido = int.TryParse(Console.ReadLine(), out int n1);

            if (convertido == true)
            {
                goto convertir;
            }
            else
            {
                goto inicio;
            }

        convertir:  int n11 = Convert.ToInt32(n1.ToString());


            if (n11 == 0)
            {
                Console.WriteLine("RESULTADO>> CERO");
            }else if (n11 < 0)
            {
                Console.WriteLine("RESULTADO>> NEGATIVO");
            }
            else if (n11 > 0)
            {
                Console.WriteLine("RESULTADO>> POSITIVO");
            }

        }
    }
}
 
