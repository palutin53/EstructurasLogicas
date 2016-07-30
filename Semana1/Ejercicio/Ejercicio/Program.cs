using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicio

            Console.WriteLine("¡Hola! ingresa tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("¡Hola! "+nombre+" presiona enter para continuar");
            while (Console.ReadKey().Key!=ConsoleKey.Enter) { }
            Console.Clear();

            //Validación de repeticion

            bool valid = true;
            while (valid)
            {
                //Menú

                Console.WriteLine("Escoge la opcion que desees utilizar:");
                Console.WriteLine(" 1. Ejercicio 1");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion) {

                    case 1:

                    //Ejercicio 2

                    Console.WriteLine("Ingresa 3 letras y le cambiaremos el orden.");
                    Console.WriteLine("Ingresa el Primer Numero:");
                    string letra1 = Console.ReadLine();
                    Console.WriteLine("Ingresa el Segundo Numero:");
                    string letra2 = Console.ReadLine();
                    Console.WriteLine("Ingresa el Tercer Numero:");
                    string letra3 = Console.ReadLine();
                    Console.WriteLine("Presiona enter para ver el orden inverso.");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    Console.WriteLine("La cadena quedan así: " + letra1 + "  " + letra2 + "  " + letra3);
                    Console.WriteLine("Presiona enter para volver al menú");
                    Console.Clear();
                    opcion = 0;
                    valid = true;
                        break;
                    case 2:

                        // Ejercicio 2



                        break;
                    default:
                        break;
            }
            }
        }
    }
}
