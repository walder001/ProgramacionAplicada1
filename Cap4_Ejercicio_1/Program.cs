using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap4_Ejercicio_1
{
    class Program
    {
        /// <summary>
        /// 1 Hacer un programa que muestre la tabla
        /// de multiplicar del 1 al 10 de cualquiernúmero.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i<= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}",i,j,i*j);

                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
