using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 8
            // Inicio

            Console.WriteLine("¡Hola! Ingresa Tu Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("¡Hola: " + nombre + "!");
            Console.WriteLine("Presiona enter para comenzar");
            Console.ReadKey();
            Console.Clear();

            // Validación 
            bool valid = true;
            while (valid)
            {

                //Menú

                Console.WriteLine("Ingresa una de las siguientes opciones dependiendo de lo que quieras hacer:");
                Console.WriteLine(" 1.empezar");
                Console.WriteLine(" 2.Salir");

                //decicion del usuario

                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                //Bucle

                switch (opcion)
                {

                    case 1:

                        //Tablas de Multiplicar

                        Console.WriteLine("Ok, " + nombre + " vamos a trabajar con las tablas de multiplicar.");
                        Console.WriteLine("¿Con que tabla de multiplicar quieres empezar?");
                        int tabla = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Muy bien, la tabla del " + tabla + " es: ");
                        Console.WriteLine();
                        Console.WriteLine(tabla + " X 1 = " + tabla * 1);
                        Console.WriteLine(tabla + " X 2 = " + tabla * 2);
                        Console.WriteLine(tabla + " X 3 = " + tabla * 3);
                        Console.WriteLine(tabla + " X 4 = " + tabla * 4);
                        Console.WriteLine(tabla + " X 5 = " + tabla * 5);
                        Console.WriteLine(tabla + " X 6 = " + tabla * 6);
                        Console.WriteLine(tabla + " X 7 = " + tabla * 7);
                        Console.WriteLine(tabla + " X 8 = " + tabla * 8);
                        Console.WriteLine(tabla + " X 9 = " + tabla * 9);
                        Console.WriteLine(tabla + " X 10 = " + tabla * 10);
                        Console.WriteLine("\nPresiona enter para continuar");
                        Console.ReadKey();
                        Console.Clear();

                        //anidado1
                        Console.WriteLine("¿Quieres intentar con otra?");
                        Console.WriteLine(" 1.Si");
                        Console.WriteLine(" 2.Salir");
                        int repetir = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (repetir)
                        {
                            case 1:

                                Console.WriteLine("Enter para continuar.");
                                Console.ReadKey();
                                Console.Clear();
                                opcion = 0;
                                valid = true;

                                break;
                            case 2:

                                Console.WriteLine("FIN DEL PROGRAMA");
                                Console.ReadKey();
                                valid = false;

                                break;
                            default:

                                Console.WriteLine("número invalido");
                                Console.WriteLine("Enter para continuar.");
                                Console.ReadKey();
                                Console.Clear();
                                opcion = 0;
                                valid = true;

                                break;
                        }

                        break;
                    case 2:

                        Console.WriteLine("¿Quieres Salir?");
                        Console.WriteLine(" 1.Si");
                        Console.WriteLine(" 2.No");
                        int salir = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (salir)
                        {

                            case 1:

                                Console.WriteLine("FIN DEL PROGRAMA");
                                Console.ReadKey();
                                opcion = 0;
                                valid = false;                               

                                break;
                            case 2:

                                opcion = 0;
                                valid = true;
                                Console.ReadKey();
                                Console.Clear();

                                break;
                            default:

                                Console.WriteLine("Selección Inválida.");
                                Console.ReadKey();
                                Console.Clear();
                                opcion = 0;
                                valid = true;

                                break;

                        }

                        break;
                    default:

                        Console.WriteLine("Selección Inválida.");
                        Console.WriteLine("Presiona enter para continuar.");
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
