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
            int contador = 0;
            int nav = 0;
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

                            Console.WriteLine("Presiona enter para poder visualizar el contenido de la lista, despues enter para continuar.");
                            enter();
                            if (nombres[0] == null)
                            {
                                Console.WriteLine("Por el momento la lista está vacía.");
                                enter();
                                Console.Clear();
                                Console.WriteLine("Presiona enter para continuar");
                                enter();
                                Console.Clear();
                                validsub = false;
                            } else {
                                Console.WriteLine(" ");
                                foreach (string s in nombres)
                                {
                                    Console.WriteLine(s);
                                }
                                enter();
                                Console.Clear();
                                validsub = salir();
                            }
                            opcion = 0;
                        }
                        break;
                    case 2:
                        while (validsub) {
                            // Insertar registros

                            bool blanco;

                            Console.WriteLine("Ingresar nuevos registros.");
                            enter();
                            Console.WriteLine("Recuerda que solo tenemos 10 espacios, presiona enter para proceder a agregar nuevos registros.");
                            enter();
                            Console.Clear();

                            foreach (string s in nombres)
                            {
                                blanco = string.IsNullOrEmpty(s);
                            }
                            
                            if (contador < 10)
                            {
                                Console.WriteLine("Ok, ingresa el nombre que quieres ingresar en la lista:");
                                string nuevonombre = Console.ReadLine();
                                Console.WriteLine("Ok, el nombre a ingresar es: " + nuevonombre + ", presiona enter para continuar");
                                enter();
                                Console.Clear();

                                

                                while (nombres[nav] == null)
                                {
                                    nombres[nav] = nuevonombre;
                                    Console.WriteLine("Se ha ingresado con exito el nombre: " + nuevonombre + ".\nPresiona enter para continuar.");
                                    Console.WriteLine(" ");
                                    // ------------------------------------------------------------------
                                    foreach (string s in nombres)
                                    {
                                        Console.WriteLine(s);
                                    }
                                    // --------------------------------------------------------------------
                                    enter();
                                    contador = contador + 1;
                                    Console.Clear();
                                }
                                nav = nav + 1;
                            }
                            else
                            {
                                Console.WriteLine("La lista está llena, tienes que borrar registros para ingresar nuevos.");
                                enter();
                                Console.Clear();
                                validsub = false;
                                                               
                            }
                            

                            validsub = salir();
                        }
                        break;
                    case 3:
                        while (validsub)
                        {
                            //Modificar registros

                            Console.WriteLine("Vamos a actualizar datos.");
                            enter();
                            Console.WriteLine("Actualmente la lista de nombre está así:");
                            Console.WriteLine(" ");

                            foreach(string s in nombres)
                            {
                                Console.WriteLine(s);
                            }

                            Console.WriteLine("Presiona enter para editar algun registro:");
                            enter();

                            Console.WriteLine("\ncon numeros de 1 a 10, ingresa la posicion en la que quieres sustituir.");
                            int posicion = int.Parse(Console.ReadLine());
                            posicion = posicion - 1;

                            Console.WriteLine("El nombre a editar es: "+nombres[posicion]);
                            enter();
                            Console.WriteLine("ahora ingresa el nuevo nombre:");
                            string nuevonombre = Console.ReadLine();

                            while (nav == posicion)
                            {

                            }

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
                        Console.WriteLine("¿Quieres salir?\n 1. Si\n 2. No");
                        int sal = int.Parse(Console.ReadLine());

                        switch (sal)
                        {
                            case 1:
                                Console.WriteLine("Presiona enter para Salir.");
                                enter();
                                Console.Clear();
                                valid = false;
                                break;
                            case 2:
                                Console.WriteLine("Presiona enter para retornar.");
                                enter();
                                Console.Clear();
                                valid = true;
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
