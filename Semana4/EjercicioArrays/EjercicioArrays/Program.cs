using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicio

            Console.WriteLine("Ingresa tu  nombre: ");
            string nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ok, "+nombre+" Tenemos una lista de 10 numbres, presiona enter para ver que opciones tenemos para modificarla.");
            enter();
            Console.Clear();

            // Creando Array

            string[] nombres = new string[10];

            // Variables globales
            bool valid = true;
            bool validsub = true;

            while (valid)
            {
                Console.WriteLine("Ingresa el valor depende de lo que quieras hacer.");
                Console.WriteLine(" 1. Visualizar todos los registros.");
                Console.WriteLine(" 2. Insertar registros.");
                Console.WriteLine(" 3. Modificar registros.");
                Console.WriteLine(" 4. Borrar registros");
                Console.WriteLine(" 5. SALIR.");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion) {
                    case 1:
                        while (validsub)
                        {
                            // Visualizar registros del array

                            Console.WriteLine("Presiona entera para poder visualizar el contenido de la lista, despues enter para continuar.");
                            enter();
                            if ()
                            {
                                Console.WriteLine("Por el momento la lista está vacía.\nPresiona enter para continuar");
                                enter();
                                Console.Clear();
                                validsub = false;
                            } else {
                                foreach (string s in nombres)
                                {
                                    Console.WriteLine(s);
                                }
                                enter();
                                Console.Clear();
                                validsub = salir();
                            }
                        }
                        break;
                    case 2:
                        while (validsub) {
                            // Insertar registros

                            validsub = salir();
                        }
                        break;
                    case 3:
                        while (validsub)
                        {
                            //Modificar registros

                            validsub = salir();
                        }
                        break;
                    case 4:
                        while (validsub)
                        {
                            // Borrar Resgistros

                            validsub = salir();
                        }
                        break;
                    case 5:
                        // SALIR
                        Console.WriteLine("¿Quieres intentarlo de nuevo?\n 1. Si\n 2. No");
                        int sal = int.Parse(Console.ReadLine());

                        switch (sal)
                        {
                            case 1:
                                Console.WriteLine("Presiona enter para retornar.");
                                enter();
                                Console.Clear();
                                valid = true;
                                break;
                            case 2:
                                Console.WriteLine("Presiona enter para salir.");
                                enter();
                                Console.Clear();
                                valid = false;
                                break;
                            default:
                                Console.WriteLine("Valor invalido, presiona enter para continuar");
                                enter();
                                Console.Clear();
                                valid = true;
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Seleccion invalida, presiona enter para continuar.");
                        enter();
                        Console.Clear();
                        valid = true;
                        break;
                }
            }
        }
        static void enter()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
        static bool salir()
        {
            bool validsub = true;

            Console.WriteLine("¿Quieres intentarlo de nuevo?\n 1. Si\n 2. No");
            int salida = int.Parse(Console.ReadLine());

            switch (salida)
            {
                case 1:
                    Console.WriteLine("Presiona enter para retornar.");
                    enter();
                    Console.Clear();
                    validsub = true;
                    break;
                case 2:
                    Console.WriteLine("Presiona enter para salir.");
                    enter();
                    Console.Clear();
                    validsub = false;
                    break;
                default:
                    Console.WriteLine("Valor invalido, presiona enter para continuar");
                    enter();
                    Console.Clear();
                    validsub = true;
                    break;
            }
            return validsub;
        }
    }
}
