using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap4_Ejercicio_2
{
    class Program
    {
        /// <summary>
        /// 2 Hacer un programa que calcule el
        /// resultado de un número elevado a
        /// cualquier potencia.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string valor = "";
            float bases = 0.0f;
            float exponente = 0.0f;
            do
            {
                Console.Write("Base: ");
                valor = Console.ReadLine();
                bases = Convert.ToSingle(valor);

                Console.Write("Exponente: ");
                valor = Console.ReadLine();
                exponente = Convert.ToSingle(valor);

                Console.WriteLine("La potencia es {0}", Math.Pow(bases, exponente));

                Console.Write("Preciones si para continuar no para detenerse:");
                valor = Console.ReadLine();

            } while (valor != "no");

            Console.ReadKey();
        }
    }
}
