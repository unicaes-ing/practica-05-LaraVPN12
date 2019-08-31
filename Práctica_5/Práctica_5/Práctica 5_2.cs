using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_5
{
    class Práctica_5_2
    {
        static int Valor(int numero)
        {
            return numero;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero:");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            if (cantidad == 0)
            {
                Console.WriteLine("El número ingresado tiene un valor de 0");
            }
            if (cantidad < 0)
            {
                Console.WriteLine("El número {0:N2} es negativo",Valor(cantidad));
            }
            if (cantidad > 0)
            {
                Console.WriteLine("El número {0:N2} es positivo",Valor(cantidad));
            }
            Console.ReadKey();

        }
    }
}
