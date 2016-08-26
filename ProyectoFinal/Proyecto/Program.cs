using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {

            bool valid = true;
            string[] arreglo = new string[100];
            

            while (valid) {
                
                bool validsub = true;
                int nav = 0;
                double a = 0, x, y;
                int contador = 0, sum = 0;
                char signo;

                Console.WriteLine("Selecciona según lo que quieras hacer:\n 1. Instrucciones\n 2. Calculadora\n 3. SALIR");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        while (validsub)
                        {
                            Console.WriteLine("");
                            enter();
                            Console.Clear();
                            validsub = salir(arreglo);
                        }                        
                        break;
                    case 2:
                        //----------------------------------------------------------------------------------------------------------------
                        while (validsub)
                        {
                            for (nav = 0; validsub == true; nav++)
                            {
                                
                                if (contador == 0)
                                {
                                    Console.WriteLine("Escribe un numero.");
                                    foreach (string s in arreglo)
                                    {
                                        Console.Write(s);
                                    }
                                    x = int.Parse(Console.ReadLine());
                                    arreglo[sum] = Convert.ToString(x);
                                    sum++;
                                    Console.Clear();
                                    Console.WriteLine("ingresa el operador");
                                    foreach (string s in arreglo)
                                    {
                                        Console.Write(s);
                                    }
                                    signo = char.Parse(Console.ReadLine());
                                    arreglo[sum] = Convert.ToString(signo);
                                    sum++;
                                    foreach (string s in arreglo)
                                    {

                                        Console.Write(s);

                                    }
                                    Console.Clear();
                                    Console.WriteLine("Ingresa un numero");
                                    foreach (string s in arreglo)
                                    {
                                        Console.Write(s);
                                    }
                                    y = int.Parse(Console.ReadLine());
                                    arreglo[sum] = Convert.ToString(y);
                                    sum++;

                                    Console.Clear();
                                    switch (signo)
                                    {
                                        case '+':
                                            a = x + y;
                                            contador = contador + 1;
                                            break;
                                        case '-':
                                            a = x - y;
                                            contador = contador + 1;
                                            break;
                                        case '*':
                                            a = x * y;
                                            contador = contador + 1;
                                            break;
                                        case '/':
                                            a = x / y;
                                            contador = contador + 1;
                                            break;
                                        case '=':
                                            nav = 80;
                                            break;
                                        default:
                                            Console.WriteLine("Dato incorrecto.");
                                            enter();
                                            Console.Clear();
                                            break;
                                    }
                                }
                                else if (contador == 1)
                                {
                                    Console.WriteLine("ingresa el operador");
                                    foreach (string s in arreglo)
                                    {
                                        Console.Write(s);
                                    }
                                    signo = char.Parse(Console.ReadLine());
                                    arreglo[sum] = Convert.ToString(signo);
                                    sum++;
                                    Console.Clear();
                                    if (signo == '=')
                                    {
                                        Console.WriteLine("La respuesta de");
                                        foreach (string s in arreglo)
                                        {
                                            Console.Write(s);
                                        }
                                        Console.WriteLine("\nes: " + a);
                                        enter();
                                        Console.Clear();
                                        validsub = salir(arreglo);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ingres un numero");
                                        foreach (string s in arreglo)
                                        {
                                            Console.Write(s);
                                        }
                                        y = int.Parse(Console.ReadLine());
                                        arreglo[sum] = Convert.ToString(y);
                                        sum++;
                                        Console.Clear();

                                        switch (signo)
                                        {
                                            case '+':
                                                a = a + y;
                                                break;
                                            case '-':
                                                a = a - y;
                                                break;
                                            case '*':
                                                a = a * y;
                                                break;
                                            case '/':
                                                a = a / y;
                                                break;
                                            case '=':
                                                signo = '=';
                                                break;
                                            default:
                                                Console.WriteLine("Dato incorrecto.\nPresiona enter.");
                                                enter();
                                                Console.Clear();
                                                validsub = salir(arreglo);
                                                break;
                                        }
                                    }
                                }

                            }
                        }
                        //----------------------------------------------------------------------------------------------------------------
                        break;
                    case 3:
                        Console.WriteLine("¿Quieres salir?\n 1. Si\n 2. No");
                        int salida = int.Parse(Console.ReadLine());
                        switch (salida)
                        {
                            case 1:
                                Console.WriteLine("Presiona enter para salir.");
                                enter();
                                valid = false;
                                Console.Clear();
                                break;
                            case 2:
                                Console.WriteLine("Presiona enter para retornar.");
                                enter();
                                valid = true;
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Valor invalido, Presiona enter.");
                                enter();
                                valid = true;
                                Console.Clear();
                                break;
                        }
                        break;
                    default:

                        break;
                }
            }
        }
        static void enter()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter);
        }
        static bool salir(string[] arreglo)
        {
            int borrar = 0;
            bool validsub = true;
            Console.WriteLine("¿Quieres intentar de nuevo?\n 1. Si\n 2. No");
            int salida = int.Parse(Console.ReadLine());
            switch (salida)
            {
                case 1:
                    Console.WriteLine("Presiona enter para retornar.");
                    enter();
                    validsub = true;
                    for (borrar = 0; borrar < 100; borrar++)
                    {
                        arreglo[borrar] = null;
                    }
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("Presiona enter para salir.");
                    enter();
                    validsub = false;
                    for (borrar = 0; borrar < 100; borrar++)
                    {
                        arreglo[borrar] = null;
                    }
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Valor invalido, Presiona enter.");
                    enter();
                    validsub = false;
                    for (borrar = 0; borrar < 100; borrar++)
                    {
                        arreglo[borrar] = null;
                    }
                    Console.Clear();
                    break;
            }
            return validsub;
        }
    }
}