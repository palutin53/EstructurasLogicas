using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicio

            Console.WriteLine("¡Hola! Ingresa Tu Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("¡Hola: " + nombre + "!");
            Console.WriteLine("Presiona enter para comenzar");
            Console.ReadKey();
            Console.Clear();

            //Ejercicio 7//

            Console.WriteLine("Muy bien, esto trabaja muy parecido a una calculadora, vamos a poder resolver suma, resta, multiplicación y dividisión de dos números.");
            Console.WriteLine("Presiona enter cuando estes listo");
            Console.ReadKey();
            Console.Clear();

            // Validación 
            bool valid = true;
            while (valid)
            {

                Console.WriteLine("Ingresa una de las siguientes opciones dependiendo de lo que quieras hacer:");
                Console.WriteLine(" 1.Suma");
                Console.WriteLine(" 2.Resta");
                Console.WriteLine(" 3.Multiplicación");
                Console.WriteLine(" 4.División");
                Console.WriteLine(" 5.Salir");

                //decicion del usuario
                int opcion = int.Parse(Console.ReadLine());

                //bucle
                switch (opcion)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("Bien, vamos a hacer una Suma.");
                        Console.WriteLine("Ingresa un numero: ");
                        double suma1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa otro numero: ");
                        double suma2 = int.Parse(Console.ReadLine());
                        double suma = suma1 + suma2;
                        Console.WriteLine("Al sumar " + suma1 + " y " + suma2 + " El resultado es: " + suma);
                        Console.WriteLine("Presiona Enter para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        valid = true;
                        opcion = 0;

                        break;
                    case 2:

                        Console.Clear();
                        Console.WriteLine("Bien, vamos a hacer una Resta.");
                        Console.WriteLine("Ingresa un numero: ");
                        double resta1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa otro numero: ");
                        double resta2 = int.Parse(Console.ReadLine());
                        double resta = resta1 - resta2;
                        Console.WriteLine("Al restar " + resta1 + " y " + resta2 + " El resultado es: " + resta);
                        Console.WriteLine("Presiona Enter para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        valid = true;
                        opcion = 0;

                        break;
                    case 3:

                        Console.Clear();
                        Console.WriteLine("Bien, vamos a hacer una Multiplicación.");
                        Console.WriteLine("Ingresa un numero: ");
                        double multi1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa otro numero: ");
                        double multi2 = int.Parse(Console.ReadLine());
                        double multi = multi1 * multi2;
                        Console.WriteLine("Al multiplicar " + multi1 + " y " + multi2 + " El resultado es: " + multi);
                        Console.WriteLine("Presiona Enter para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        valid = true;
                        opcion = 0;

                        break;
                    case 4:

                        Console.Clear();
                        Console.WriteLine("Bien, vamos a hacer una Dividisión.");
                        Console.WriteLine("Ingresa un numero: ");
                        double division1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa otro numero: ");
                        double division2 = int.Parse(Console.ReadLine());
                        double division = division1 / division2;
                        Console.WriteLine("Al dividir " + division1 + " y " + division2 + " El resultado es: " + division);
                        Console.WriteLine("Presiona Enter para continuar.");
                        Console.ReadLine();
                        Console.Clear();
                        valid = true;
                        opcion = 0;

                        break;
                    case 5:

                        Console.Clear();
                        Console.WriteLine("¿Quieres salir?");
                        Console.WriteLine(" 1.Si");
                        Console.WriteLine(" 2.No");
                        int salir = int.Parse(Console.ReadLine());

                        switch (salir)
                        {

                            case 1:

                                Console.Clear();
                                Console.WriteLine("FIN DEL PROGRAMA");
                                Console.ReadKey();
                                Console.Clear();
                                valid = false;

                                break;
                            case 2:

                                Console.Clear();
                                Console.WriteLine("Presiona Enter para continuar.");
                                Console.ReadKey();
                                Console.Clear();
                                opcion = 0;
                                valid = true;

                                break;
                            default:

                                Console.Clear(); ;
                                Console.WriteLine("Selección Invalida");
                                Console.WriteLine("Presiona Enter para continuar.");
                                Console.ReadKey();
                                Console.Clear();
                                opcion = 0;
                                valid = true;

                                break;
                        }

                        break;
                    default:

                        Console.Clear();
                        Console.WriteLine("Numero No Válido.");
                        Console.WriteLine("Presiona Enter para continuar.");
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