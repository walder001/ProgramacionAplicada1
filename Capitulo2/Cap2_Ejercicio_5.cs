using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 5 Hacer un programa que transforme entre
//dólares y euros y que también pida el tipo
//de cambio del día.
/// </summary>

namespace Cap2_Ejercicio_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            const float Dom = 50.50f;
            string valor = "";
            int moneda = 0;
            int cantidad = 0;
            int opcion = 0;
            Console.Write("1: Dolar\n2:Euro\nIngrese la moneda que decea cambiar:");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            
            if(opcion == 1)
            {
                Console.Write("1: Peso dominicano");
                valor = Console.ReadLine();
                moneda = Convert.ToInt32(valor);
                if (moneda == 1)
                {
                    Console.Write("Cantidad de Dolares: ");
                    valor = Console.ReadLine();
                    cantidad = Convert.ToInt32(valor);
                    Console.WriteLine(" {0} pesos dominicanos", cantidad * Dom);

                    Console.ReadKey();

                }
            }
                
            

         

        }
    }
}
