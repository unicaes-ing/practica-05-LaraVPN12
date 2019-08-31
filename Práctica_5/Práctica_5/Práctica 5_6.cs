using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_5
{
    class Práctica_5_6
    {
        static double Promedio(double[] calificaciones)
        {
            double nota,total=0.0;
            for (int i = 0; i < calificaciones.Length; i++)
            {
                nota = calificaciones[i];
                total += nota;
            }
            total = total / calificaciones.Length;
            return total;
        }
        
        static void Main(string[] args)
        {
            double[] notas;
            double auxiliar=0.0;
            int cantidad,i;
            Console.WriteLine("Ingrese la cantidad de estudiantes:");
            cantidad = Convert.ToInt32(Console.ReadLine());
            notas = new double[cantidad];
            for (i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese la nota del estudiante #{0}",i+1);
                double valor = Convert.ToDouble(Console.ReadLine());
                notas[i] = valor;
                auxiliar = Promedio(notas);
            }

            Console.WriteLine("Promedio: {0}",Promedio(notas));
            Console.ReadKey();

        }

        
    }
}
