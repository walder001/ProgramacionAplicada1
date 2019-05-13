using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap4_Ejercicio_5
{
    public class Program
    {
        /// <summary>
        /// 5 Hacer un programa que calcule el
        ///  promedio de edad de un grupo de
        ///personas y diga cuál es la de edad más
        /// grande y cuál es la más joven.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string valor = "";
            int persona = 0;
            int edad = 0;
            int acumulador = 0;
            int mayor = 0;
            int menor = 0;

            Console.Write("Cantidad de persona: ");
            valor = Console.ReadLine();
            persona = Convert.ToInt32(valor);

            for(int i = 0; i<= persona; i++)
            {
                Console.Write("Edad: ");
                valor = Console.ReadLine();
                edad = Convert.ToInt32(valor);
                if(edad > acumulador)
                {
                    edad = mayor;
                   

                }
                if (edad < acumulador)
                {
                    edad = menor;
                  
                }
                
            }

            Console.Write("Edad mayor es: {0}", mayor);

            Console.Write("Edad menor es: {0}", menor);

            Console.ReadLine();



        }
    }
}
