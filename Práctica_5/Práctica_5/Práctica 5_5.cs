using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_5
{
    class Práctica_5_5
    {
        static double Precio(double monto,double descuento)
        {
            double total = 0.0;
            descuento = descuento * 0.010;
            if (descuento != 0)
            {
                total = monto + (monto * descuento);
                return total;
            }
            else
            {
                return monto;
            }
            
        }
        static void Main(string[] args)
        {
            double precio = 0, porcentaje = 0;
            do
            {
                Console.WriteLine("Ingrese el precio del producto");
                 precio = Convert.ToDouble(Console.ReadLine());
            } while (precio <= 0);

            do
            {
                Console.WriteLine("Ingrese el porcentaje de descuento");
                porcentaje = Convert.ToDouble(Console.ReadLine());
            } while (porcentaje < 0 || porcentaje > 100);

            Console.WriteLine("Valor de descuento: {0:P}\nMonto a pagar: {1:C2}", porcentaje/100, Precio(precio, porcentaje));
            Console.ReadKey();

            

        }
    }
}
