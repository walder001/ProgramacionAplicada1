using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ejercicio_5
{
    class Program
    {
        /// <summary>
        /// Hacer una programa que pueda calcular
        /// el perímetro y el área de cualquier
        ///polígono regular, pero que le pregunte al
        ///usuario qué desea calcular.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string valor = "";
            int opcion = 0;
            string dato1 = "";
            string dato2 = "";
            string dato3 = "";
            float area = 0.0f;
            float perimetro = 0.0f;
            float bases = 0.0f;
            float altura = 0.0f;
            float lado = 0.0f;
            float diametro = 0.0f;
            float radio = 0.0f;


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
                    area = (bases * altura) / 2;

                    Console.Write("\nEl area es {0} y el perimetro es {1}",area,perimetro);
                    break;
                case 2:
                    Console.Write("Altura: ");
                    dato1 = Console.ReadLine();
                    altura = Convert.ToSingle(dato1);

                    perimetro = altura * 4;
                    area = altura * altura;

                    Console.Write("\nEl area del cuadrado es {0} y el perimetro es {1}", area, perimetro);
                    break;
                case 3:
                    Console.Write("Base: ");
                    dato1 = Console.ReadLine();
                    bases = Convert.ToSingle(dato1);

                    Console.Write("Altura: ");
                    dato2 = Console.ReadLine();
                    altura = Convert.ToSingle(dato2);

                    perimetro = (bases * 2) + (altura * 2);
                    area = (bases * altura);

                    Console.Write("\nEl area del rectangulo es {0} y el perimetro es {1}", area, perimetro);
                    break;

                case 4:
                    Console.Write("Diagonal mayor: ");
                    dato1 = Console.ReadLine();
                    bases = Convert.ToSingle(dato1);

                    Console.Write("Diagonal menor: ");
                    dato2 = Console.ReadLine();
                    altura = Convert.ToSingle(dato2);

                    Console.Write("Lado: ");
                    dato3 = Console.ReadLine();
                    lado = Convert.ToSingle(dato2);

                    perimetro = lado * 4;
                    area = (bases * altura) /2;

                    Console.Write("\nEl area del rombo es {0} y el perimetro es {1}", area, perimetro);
                    break;
                case 5:
                    Console.Write("Diametro: ");
                    dato1 = Console.ReadLine();
                    diametro = Convert.ToSingle(dato1);

                    radio = diametro / 2;
                    area = 3.1416f * (radio * radio);
                    perimetro = diametro * 3.1416f;

                    Console.Write("\nEl area del circulo es {0} y el perimetro es {1}", area, perimetro);
                    break;

                default:
                    Console.WriteLine("Numero no valido");
                    break;


            }

            Console.ReadKey();

        }
    }
}
