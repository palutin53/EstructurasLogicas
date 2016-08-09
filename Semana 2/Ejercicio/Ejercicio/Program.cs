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

                //validacion para sub-menu
                bool validsub = true;

                switch (opcion)
                {
                    
                    case 1:

                        //Ejercicio 1

                        while (validsub)
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

                           

                        }

                        break;
                    case 2:

                        // Ejercicio 2

                        while (validsub)
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

                        }

                        break;
                    case 3:

                        while (validsub)
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
                        
                        }
                        break;
                    case 4:

                        while (validsub)
                        {

                            Console.WriteLine("Ok, vamos a hacer operaciones aritmeticas, ingresa los numeros y la operacion (+ , - , * , /) que desees realizar.");
                            Console.WriteLine("Presiona enter cuando estés listo.");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                            Console.Clear();
                            Console.WriteLine("Recuerda que puedes hacer 4 básicas operaciones (+ , - , * , / ).");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                            Console.WriteLine("Ok, ahora ingresa el primer numero para operar.");
                            double num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("¿Qué operación quieres realizar?.");
                            char op = char.Parse(Console.ReadLine());
                            Console.WriteLine("Y el segundo numero.");
                            double num2 = int.Parse(Console.ReadLine());

                            if (op == '+' || op == '-' || op == '*' || op == '/')
                            {
                                if(op == '+')
                                {
                                    double suma = num1 + num2;
                                    Console.WriteLine("El resultado de "+num1+" "+op+" "+num2+" es: "+suma);
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                    Console.Clear();
                                }
                                else { }
                                if (op == '-')
                                {
                                    double resta = num1 - num2;
                                    Console.WriteLine("El resultado de " + num1 + " " + op + " " + num2 + " es: " + resta);
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                    Console.Clear();
                                }
                                else { }
                                if (op == '*')
                                {
                                    double multi = num1 * num2;
                                    Console.WriteLine("El resultado de " + num1 + " " + op + " " + num2 + " es: " + multi);
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                    Console.Clear();
                                }
                                else { }
                                if (op == '/')
                                {
                                    double div = num1 / num2;
                                    Console.WriteLine("El resultado de " + num1 + " " + op + " " + num2 + " es: " + div);
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                    Console.Clear();
                                }
                                else { }
                            }
                            else
                            {
                                Console.WriteLine("Operador incorrecto.");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                Console.Clear();
                                validsub = true;
                            }

                        }

                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
            }
        }

        //Funcion salir 

        static void salir()
        {
            Console.WriteLine("¿Quieres intentar de nuevo?\n 1. Si\n 2. No");
            int salir = int.Parse(Console.ReadLine());
            bool validsub = true;

            switch (salir)
            {
                case 1:
                    Console.WriteLine("presiona enter para retornar.");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    Console.Clear();
                    validsub = true;
                    break;
                case 2:
                    Console.WriteLine("Presiona enter para salir.");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    Console.Clear();
                    validsub = false;
                    break;
                default:
                    Console.WriteLine("Selección invalida.");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    Console.Clear();
                    validsub = true;
                    break;
            }
        }

    }
}