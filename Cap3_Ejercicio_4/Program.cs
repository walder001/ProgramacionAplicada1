using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 4 Hacer un programa que le pida al usuario
//un número del 1 al 7 y escriba el nombre
//del día que corresponde ese número en la semana.
/// </summary>

namespace Cap3_Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "";
            int numero = 0;
            Console.Write("Ingrese el numero deceado: ");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueve");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;

                    Console.ReadKey();

            }
            Console.ReadKey();

        }
    }
}
