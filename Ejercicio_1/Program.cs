using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap2_Ejercicio_1
{
    class Program
    {
        /// <summary>
        /// 1 Hacer un programa que calcule el
        /// perímetro de cualquier polígono regular.
        /// </summary>
        static void Main(string[] args)
        {
            string valor = "";
            int opcion = 0;
            string dato1 = "";
            string dato2 = "";
            float perimetro = 0.0f;
            float bases = 0.0f;
            float altura = 0.0f;
            float lado = 0.0f;
            float diametro = 0.0f;


            Console.WriteLine("Determinar el area y el perimetro de los Siguintes poligonos");
            Console.WriteLine("1:Triangulo\n2:Cuadrado\n3:Rectangulo\n4:Rombo\n5:Circulo");
            Console.Write("Elegir una opcion: ");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);
            switch (opcion)
            {
                case 1:
                    Console.Write("Base: ");
                    dato1 = Console.ReadLine();
                    bases = Convert.ToSingle(dato1);

                    Console.Write("Altura: ");
                    dato2 = Console.ReadLine();
                    altura = Convert.ToSingle(dato2);

                    perimetro = altura + altura + bases;

                    Console.Write("\nEl perimetro es {0}", perimetro);
                    break;
                case 2:
                    Console.Write("Altura: ");
                    dato1 = Console.ReadLine();
                    altura = Convert.ToSingle(dato1);

                    perimetro = altura * 4;

                    Console.Write("\nEl perimetro es {0}", perimetro);
                    break;
                case 3:
                    Console.Write("Base: ");
                    dato1 = Console.ReadLine();
                    bases = Convert.ToSingle(dato1);

                    Console.Write("Altura: ");
                    dato2 = Console.ReadLine();
                    altura = Convert.ToSingle(dato2);

                    perimetro = (bases * 2) + (altura * 2);

                    Console.Write("\nEl perimetro es {0}", perimetro);
                    break;

                case 4:
                    Console.Write("Lado: ");
                    dato1 = Console.ReadLine();
                    lado = Convert.ToSingle(dato1);

                    perimetro = lado * 4;

                    Console.Write("\nEl perimetro es {0}", perimetro);
                    break;
                case 5:
                    Console.Write("Diametro: ");
                    dato1 = Console.ReadLine();
                    diametro = Convert.ToSingle(dato1);
                    perimetro = diametro * 3.1416f;

                    Console.Write("\nEl perimetro es {0}", perimetro);
                    break;

                default:
                    Console.WriteLine("Numero no valido");
                    break;
            }
            Console.ReadKey();

        }
    }
}
