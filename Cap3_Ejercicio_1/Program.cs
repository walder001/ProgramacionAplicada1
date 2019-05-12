using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ejercicio_1
{
    class Program
    {
        /// <summary>
        /// 1 Hacer un programa que le pida al usuario
        /// un número y la computadora responda si
        /// es par o impar.
        /// </summary>
        /// <param name="args"></param>
        
        static void Main(string[] args)
        {
            string numero = "";
            int valor = 0;
            Console.Write("Ingrese un numero:");
            numero = Console.ReadLine();
            valor = Convert.ToInt32(numero);

          

            if((valor % 2) == 0)
            {
                Console.WriteLine("Par");
            } else
            {
                Console.WriteLine("Impar");
            }

            Console.ReadKey();

        }
    }
}
