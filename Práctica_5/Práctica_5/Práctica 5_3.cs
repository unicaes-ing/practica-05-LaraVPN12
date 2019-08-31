using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_5
{
    class Práctica_5_3
    {
        static int Factorial(int valor)
        {
            int factorial=valor;
            for (int i = 1; i < valor; i++)
            {
                factorial = factorial * (valor - i);
                
            }
            
            return factorial;
        }
        static void Main(string[] args)
        {
            int numero=0;
            do
            {
                Console.WriteLine("Ingrese un número entero:");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero <= 0);
           
            Console.WriteLine("El factorial del numero {0:N2} es {1:N2}",numero,Factorial(numero));
            Console.ReadKey();
            

        }
    }
}
