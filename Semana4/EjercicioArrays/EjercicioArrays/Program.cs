﻿using System;
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

            while (valid)
            {
                bool validsub = true;
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
                            if (nombres[0] == null && nombres[1] == null && nombres[2] == null && nombres[3] == null && nombres[4] == null && nombres[5] == null && nombres[6] == null && nombres[7] == null && nombres[8] == null && nombres[9] == null)
                            {
                                Console.WriteLine("Por el momento la lista está vacía.");
                                Console.WriteLine("Presiona enter para continuar");
                                enter();
                                Console.Clear();
                                validsub = false;
                            } else {
                                int lugar = 1;
                                Console.WriteLine(" ");
                                foreach (string s in nombres)
                                {
                                    Console.WriteLine(lugar+". "+s);
                                    lugar = lugar + 1;
                                }
                                enter();
                                Console.Clear();
                                validsub = salir();
                            }
                        }
                        break;
                    case 2:
                        while (validsub)
                        {
                            if (contador<10)
                            {
                                // Insertar registros
                                Console.WriteLine("Para insertar nuevos nombres debes recordar 2 cosas:\n 1. No ingreses nombres repetidos.\n 2. solo tenemos espacio para 10 nombres.");
                                Console.WriteLine("Presiona enter para continuar.");
                                enter();
                                Console.Clear();
                                
                                    Console.WriteLine("Escribe el nombre para agregar en la lista:");
                                    string nuevonombre = Console.ReadLine();

                                    if (nuevonombre == "" || nuevonombre == " ")
                                    {
                                        Console.WriteLine("Debes ingresar un nombre.");
                                        enter();
                                        Console.Clear();
                                    } else
                                    {
                                        if (nombres[nav] == nuevonombre)
                                        {
                                            Console.WriteLine("No puedes ingresar nombres repetidos.");
                                            enter();
                                            Console.Clear();
                                        }else
                                        {
                                        while (nombres[nav] == null)
                                        {
                                            nombres[nav] = nuevonombre;
                                            contador = contador + 1;
                                            Console.WriteLine("Se ha ingresado con exito el nombre: " + nuevonombre + ".\nPresiona enter para continuar.");
                                            Console.WriteLine(" ");
                                            // ------------------------------------------------------------------
                                            int lugar = 1;
                                            foreach (string s in nombres)
                                            {
                                                Console.WriteLine(lugar + ". " + s);
                                                lugar = lugar + 1;
                                            }
                                            // --------------------------------------------------------------------
                                            enter();
                                            Console.Clear();
                                        }
                                        nav = nav + 1;
                                    }
                                    }
                            }else
                            {
                                Console.WriteLine("La lista está llena, debes borrar nombre para ingresar más.");
                                enter();
                                Console.Clear();
                                validsub = salir();
                            }
                            validsub = salir();
                        }
                        break;
                    case 3:
                        while (validsub)
                        {
                            //Modificar registros
                            if (nombres[0] == null && nombres[1] == null && nombres[2] == null && nombres[3] == null && nombres[4] == null && nombres[5] == null && nombres[6] == null && nombres[7] == null && nombres[8] == null && nombres[9] == null)
                            {
                                Console.WriteLine("Por el momento la lista está vacía.");
                                enter();
                                Console.Clear();
                                Console.WriteLine("Presiona enter para continuar");
                                enter();
                                Console.Clear();
                                validsub = false;
                            }
                            else
                            {
                                Console.WriteLine("Vamos a actualizar datos.");
                                enter();
                                Console.WriteLine("Actualmente la lista de nombre está así:");
                                Console.WriteLine(" ");

                                int lugar = 1;
                                foreach (string s in nombres)
                                {
                                    Console.WriteLine(lugar + ". " + s);
                                    lugar = lugar + 1;
                                }

                                Console.WriteLine("Presiona enter para editar algun registro:");
                                enter();

                                Console.WriteLine("\ncon numeros de 1 a 10, ingresa la posicion en la que quieres sustituir.");
                                int posicion = int.Parse(Console.ReadLine());
                                int posicion1 = posicion - 1;

                                Console.WriteLine("El nombre a editar es: " + nombres[posicion1]);
                                enter();
                                Console.WriteLine("ahora ingresa el nuevo nombre:");
                                string nuevonombre = Console.ReadLine();

                                for (nav = 0; nav <= posicion1; nav++)
                                {
                                    if (nav == posicion1)
                                    {
                                        nombres[posicion1] = nuevonombre;
                                        Console.WriteLine("El nombre "+nuevonombre+" se ha actualizado en la posicion "+posicion+" de la tabla.");
                                    }
                                }
                                Console.WriteLine("presiona enter para ver la nueva lista.");
                                enter();
                                Console.Clear();
                                Console.WriteLine(" ");
                                foreach (string s in nombres)
                                {
                                    Console.WriteLine(lugar + ". " + s);
                                    lugar = lugar + 1;
                                }
                                enter();
                                Console.WriteLine("Presiona enter para continuar.");
                                enter();
                                Console.Clear();
                            }
                            validsub = salir();
                        }
                        break;
                    case 4:
                        while (validsub)
                        {
                            // Borrar Resgistros

                            if (contador > 0)
                            {
                                Console.WriteLine("Así es como tenemos actualmente la lista:");
                                Console.WriteLine(" ");
                                int lugar = 1;
                                Console.WriteLine(" ");
                                foreach (string s in nombres)
                                {
                                    Console.WriteLine(lugar + ". " + s);
                                    lugar = lugar + 1;
                                }
                                Console.WriteLine("\nCon numeros del 1 al 10 ingresa cual es el nombre que quieres borrar.");
                                int posicion = int.Parse(Console.ReadLine());
                                int posicion1 = posicion - 1;

                                Console.WriteLine("El nombre que vamos a borrar es: " + nombres[posicion1]);
                                Console.WriteLine("Presiona enter para borrar el nombre.");
                                enter();
                                Console.Clear();

                                for (nav = 0; nav <= posicion1; nav++)
                                {
                                    if (nav == posicion1)
                                    {
                                        nombres[posicion1] = null;
                                        contador = contador - 1;
                                        Console.WriteLine("Se ha eliminado el nombre en la posicion "+posicion1+".");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("La lista está vacía, no puedes borrar registros que no existen.");
                                enter();
                                Console.Clear();
                            }

                            if (contador > 0)
                            {
                                Console.WriteLine("Ya borrado el registro '" + nombres[nav] + "' quedo así:");
                                Console.WriteLine(" ");

                                int lugar = 1;
                                foreach (string s in nombres)
                                {
                                    Console.WriteLine(lugar + ". " + s);
                                    lugar = lugar + 1;
                                }
                            }
                            else { }

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
