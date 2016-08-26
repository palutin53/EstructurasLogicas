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
            string[] popo = new string[100];
            int nav = 0;
            double a = 0, x, y;
            int contador = 0, sum = 0;
            char signo;

            while (valid) {
                
                bool validsub = true;
                
                Console.WriteLine("Selecciona según lo que quieras hacer:\n 1. Instrucciones\n 2. Calculadora\n 3. SALIR");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        while (validsub)
                        {
                            Console.WriteLine("puto");
                            enter();
                            Console.Clear();
                            validsub = salir();
                        }                        
                        break;
                    case 2:
                        //----------------------------------------------------------------------------------------------------------------
                        while (validsub)
                        {
                            for (nav = 0; nav <= 80; nav++)
                            {
                                if (contador == 0)
                                {
                                    Console.WriteLine("Escribe un numero.");
                                    foreach (string s in popo)
                                    {
                                        Console.Write(s);
                                    }
                                    x = int.Parse(Console.ReadLine());
                                    popo[sum] = Convert.ToString(x);
                                    sum++;
                                    Console.Clear();
                                    Console.WriteLine("ingresa el operador");
                                    foreach (string s in popo)
                                    {
                                        Console.Write(s);
                                    }
                                    signo = char.Parse(Console.ReadLine());
                                    popo[sum] = Convert.ToString(signo);
                                    sum++;
                                    foreach (string s in popo)
                                    {

                                        Console.Write(s);

                                    }
                                    Console.Clear();
                                    Console.WriteLine("Ingresa un numero");
                                    foreach (string s in popo)
                                    {
                                        Console.Write(s);
                                    }
                                    y = int.Parse(Console.ReadLine());
                                    popo[sum] = Convert.ToString(y);
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
                                    foreach (string s in popo)
                                    {
                                        Console.Write(s);
                                    }
                                    signo = char.Parse(Console.ReadLine());
                                    popo[sum] = Convert.ToString(signo);
                                    sum++;
                                    Console.Clear();
                                    if (signo == '=')
                                    {
                                        Console.WriteLine("La respuesta de");
                                        foreach (string s in popo)
                                        {
                                            Console.Write(s);
                                        }
                                        Console.WriteLine("\nes: " + a);
                                        enter();
                                        validsub = salir();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ingres un numero");
                                        foreach (string s in popo)
                                        {
                                            Console.Write(s);
                                        }
                                        y = int.Parse(Console.ReadLine());
                                        popo[sum] = Convert.ToString(y);
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
                                                validsub = salir();
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
                                Console.WriteLine("Presiona enter para retornar.");
                                enter();
                                valid = false;
                                Console.Clear();
                                break;
                            case 2:
                                Console.WriteLine("Presiona enter para salir.");
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
        static bool salir()
        {
            bool validsub = true;
            Console.WriteLine("¿Quieres intentar de nuevo?\n 1. Si\n 2. No");
            int salida = int.Parse(Console.ReadLine());
            switch (salida)
            {
                case 1:
                    Console.WriteLine("Presiona enter para retornar.");
                    enter();
                    validsub = true;
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("Presiona enter para salir.");
                    enter();
                    validsub = false;
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Valor invalido, Presiona enter.");
                    enter();
                    validsub = false;
                    Console.Clear();
                    break;
            }
            return validsub;
        }
    }
}