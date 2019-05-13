using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 3 Hacer un programa que transforme de
/// grados a radianes.
/// </summary>

namespace Cap2_Ejercicio_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            float grado = 0.0f;
            float resultado = 0.0f;
            string valor = "";
            Console.Write("Ingrese los grados: ");
            valor = Console.ReadLine();
            grado = Convert.ToSingle(valor);
            resultado = grado * 3.1416f/180;

            Console.WriteLine("La convercion es: {0}", resultado);

            Console.ReadKey();
            
        }
    }
}
