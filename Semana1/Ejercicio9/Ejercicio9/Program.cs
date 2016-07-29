using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 9
            // Inicio

            Console.WriteLine("¡Hola! Ingresa Tu Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("¡Hola: " + nombre + "!");
            Console.WriteLine("Presiona enter para comenzar");
            Console.ReadKey();
            Console.Clear();

            // Validación para repetir

            bool valid = true;
            while (valid)
            {

                //Promedio
                Console.WriteLine("Muy bien, " + nombre + " vamos a sacar el promedio de 4 números.");
                Console.WriteLine("Presiona Enter para empezar.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Ingresa el primer número: ");
                double num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo número: ");
                double num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el tercer número: ");
                double num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el cuarto número: ");
                double num4 = int.Parse(Console.ReadLine());
                Console.WriteLine("Presiona enter para ver el resultado.");
                Console.ReadKey();
                double promedio = (num1 + num2 + num3 + num4) / 4;
                Console.WriteLine("\nEl promedio de " + num1 + ", " + num2 + ", " + num3 + " y " + num4 + " es: " + promedio);
                Console.WriteLine();
                Console.WriteLine("Presiona enter para continuar.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("¿Quieres intentar con otros números?");
                Console.WriteLine(" 1.Si");
                Console.WriteLine(" 2.Salir");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                // Bucle para Salir
                switch (opcion)
                {
                    case 1:

                        opcion = 0;
                        valid = true;

                        break;
                    case 2:

                        Console.WriteLine("FIN DEL PROGRAMA");
                        Console.ReadKey();
                        opcion = 0;
                        valid = false;
                        
                        break;
                    default:

                        Console.WriteLine("Selección invalida.");
                        Console.ReadKey();
                        Console.Clear();
                        opcion = 0;
                        valid = true;

                        break;
                }
            }
        }
    }
}
