using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Práctica_5
{
    class Práctica_5_4
    {
        static string Numero_Telefono(string telefono1, string telefono2, string telefono3, string telefono4)
        {
            int nombre;
            Random lista = new Random();
            nombre= lista.Nex;
            return nombre.ToString();

        }
        static void Main(string[] args)
        {
            
            string numero1,numero2, numero3, numero4,telefonos;
            
                Console.WriteLine("Ingrese el primer numero de telefono");
                numero1 = Console.ReadLine();
                Console.WriteLine("Ingrese el segundo numero de telefono");
                numero2 = Console.ReadLine();
                Console.WriteLine("Ingrese el tercer numero de telefono");
                numero3 = Console.ReadLine();
                Console.WriteLine("Ingrese el cuarto numero de telefono");
                numero4 = Console.ReadLine();
                telefonos = Numero_Telefono(numero1, numero2, numero3, numero4);
                Console.WriteLine(telefonos);
                Console.ReadKey();

                
        }
    }
}
