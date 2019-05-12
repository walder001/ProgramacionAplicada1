using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 4 Hacer un programa que transforme de
//grados centígrados a grados Fahrenheit.
/// </summary>

namespace Cap2_Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "";
            float cel = 0.0f;
            float far = 0.0f;
            Console.Write("Ingrese los el valor: ");
            valor = Console.ReadLine();
            cel = Convert.ToSingle(valor);
            far =  (cel * 9 / 5) +32;
            Console.WriteLine("El valor en Fahreheit es: {0}", far);

            Console.ReadKey();

        }
    }
}
