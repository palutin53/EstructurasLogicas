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
            Console.WriteLine("¡Hola! " + nombre + " presiona enter para continuar");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();

            //Validación de repeticion

            bool valid = true;
            while (valid)
            {
                //Menú

                int opcion = 0;
                Console.WriteLine("Escoge la opcion que desees utilizar:");
                Console.WriteLine(" 1. Ejercicio 1");
                Console.WriteLine(" 2. Ejercicio 2");
                Console.WriteLine(" 3. Ejercicio 3");
                Console.WriteLine(" 4. Ejercicio 4");
                Console.WriteLine(" 5. Ejercicio 5");
                Console.WriteLine(" 6. Ejercicio 6");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear(); 

                switch (opcion)
                {

                    case 1:

                        //Ejercicio 1

                        bool valid1 = true;
                        while (valid1)
                        {

                            Console.WriteLine("Ingresa 3 letras y le cambiaremos el orden.");
                            Console.WriteLine("Ingresa la primera letra:");
                            string letra1 = Console.ReadLine();
                            Console.WriteLine("Ingresa la segunda letra:");
                            string letra2 = Console.ReadLine();
                            Console.WriteLine("Ingresa la tercera letra:");
                            string letra3 = Console.ReadLine();
                            Console.WriteLine("Presiona enter para ver el orden inverso.");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                            Console.WriteLine("La cadena quedan así: " + letra3 + "  " + letra2 + "  " + letra1);
                            Console.WriteLine("Presiona enter para volver al menú");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                            Console.Clear();
                            valid = true;


                            Console.WriteLine("¿Quieres intentar de nuevo?\n 1. Si\n 2. No");
                            int salir1 = int.Parse(Console.ReadLine());

                            switch (salir1)
                            {
                                case 1:
                                    Console.WriteLine("presiona enter para retornar.");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                    Console.Clear();
                                    valid1 = true;
                                    break;
                                case 2:
                                    Console.WriteLine("Presiona enter para salir.");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                    Console.Clear();
                                    valid1 = false;
                                    break;
                                default:
                                    Console.WriteLine("Selección invalida.");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                    Console.Clear();
                                    valid1 = true;
                                    break;
                            }
                        }

                        break;
                    case 2:

                        // Ejercicio 2

                        bool valid2 = true;
                        while (valid2)
                        {

                            int num, lineas, ancho;
                            Console.WriteLine("Introduzca un numero de 1 a 9 para crear un triangulo.");
                            num = int.Parse(Console.ReadLine());
                            Console.Clear();
                            for (lineas = 1; lineas <= num; lineas++)
                            {
                                for (ancho = 0; ancho <= num - lineas; ancho++)
                                {
                                    Console.Write(num);
                                }
                                Console.WriteLine();
                            }
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                            Console.Clear();

                            Console.WriteLine("¿Quieres intentar de nuevo?\n 1. Si\n 2. No");
                            int salir2 = int.Parse(Console.ReadLine());

                            switch (salir2)
                            {
                                case 1:
                                    Console.WriteLine("presiona enter para retornar.");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                    Console.Clear();
                                    valid2 = true;
                                    break;
                                case 2:
                                    Console.WriteLine("Presiona enter para salir.");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                    Console.Clear();
                                    valid2 = false;
                                    break;
                                default:
                                    Console.WriteLine("Selección invalida.");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                    Console.Clear();
                                    valid2 = true;
                                    break;
                            }
                        }

                        break;
                    case 3:

                        bool valid3 = true;
                        while (valid3)
                        {
                            int login = 1;
                        for (login = 1; login <= 3; login++)
                        {
                            Console.WriteLine("¡Bienvenido! Ingresa tu contraseña: ");
                            Console.ReadLine();
                            Console.WriteLine("Contraseña incorrecta.");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                            Console.Clear();
                        }
                        Console.WriteLine("¿Quieres intentar de nuevo?\n 1. Si\n 2. No");
                        int salir3 = int.Parse(Console.ReadLine());
                            
                            switch (salir3)
                            {
                                case 1:
                                    Console.WriteLine("presiona enter para retornar.");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                    Console.Clear();
                                    valid3 = true;
                                    break;
                                case 2:
                                    Console.WriteLine("Presiona enter para salir.");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                    Console.Clear();
                                    valid3 = false;
                                    break;
                                default:
                                    Console.WriteLine("Selección invalida.");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                    Console.Clear();
                                    valid3 = true;
                                    break;
                            }
                        }
                        break;
                    case 4:

                        bool valid4 = true;
                        while ()
                        {

                            Console.WriteLine("Ok, vamos a hacer operaciones aritmeticas, ingresa los numeros y la operacion (+ , - , * , /) que desees realizar.");

                        }

                        Console.WriteLine("¿Quieres intentar de nuevo?\n 1. Si\n 2. No");
                        int salir3 = int.Parse(Console.ReadLine());

                        switch (salir3)
                        {
                            case 1:
                                Console.WriteLine("presiona enter para retornar.");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                Console.Clear();
                                valid3 = true;
                                break;
                            case 2:
                                Console.WriteLine("Presiona enter para salir.");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                Console.Clear();
                                valid3 = false;
                                break;
                            default:
                                Console.WriteLine("Selección invalida.");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                Console.Clear();
                                valid3 = true;
                                break;
                        }

                        break;
                    default:
                        break;
                }
            }
        }
    }
}