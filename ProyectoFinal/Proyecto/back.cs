using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class back
    {
        bool validsub = true, valid = true;
        string[] array = new string[100], stack = new string[100], arraytemp = new string[100];
        double a, x, y;
        int contador = 0, nav = 0, top = 0, borrar = 0, sum;
        char signo;
        string valor;
//---------------------------------------inicio de clase--------------------------------------------------------------------------------------------
        public void enter()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
        public bool salirsub(string[] array, string[] stack, string[] arraytemp)
        {
            string sal = "¿Quieres intentar de nuevo?";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (sal.Length / 2)) + "}", sal));
            Console.WriteLine("\n 1. Si\n 2. No");
            int salida = int.Parse(Console.ReadLine());
            switch (salida)
            {
                case 1:
                    string retorno = "Presiona enter para retornar.";
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (retorno.Length / 2)) + "}", retorno));
                    enter();
                    for (borrar = 0; borrar < 100; borrar++)
                    {
                        array[borrar] = null;
                        stack[borrar] = null;
                        arraytemp[borrar] = null;
                    }
                    validsub = true;
                    Console.Clear();
                    break;
                case 2:
                    string sali = "Presiona enter para salir.";
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (sali.Length / 2)) + "}", sali));
                    enter();
                    for (borrar = 0; borrar < 100; borrar++)
                    {
                        array[borrar] = null;
                        stack[borrar] = null;
                        arraytemp[borrar] = null;
                    }
                    validsub = false;
                    Console.Clear();
                    break;
                default:
                    string inval = "Valor invalido, Presiona enter.";
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (inval.Length / 2)) + "}", inval));
                    enter();
                    for (borrar = 0; borrar < 100; borrar++)
                    {
                        array[borrar] = null;
                    }
                    validsub = false;
                    Console.Clear();
                    break;
            }
            return validsub;
        }
        public bool salir(string[] array, string[] stack, string[] arraytemp)
        {
            string qui = "¿Quieres salir?";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (qui.Length / 2)) + "}", qui));
            Console.WriteLine("\n 1. Si\n 2. No");
            int salida = int.Parse(Console.ReadLine());
            switch (salida)
            {
                case 1:
                    string pres = "Presiona enter para salir.";
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (pres.Length / 2)) + "}", pres));
                    enter();
                    valid = false;
                    Console.Clear();
                    break;
                case 2:
                    string prer = "Presiona enter para retornar.";
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (prer.Length / 2)) + "}", prer));
                    enter();
                    valid = true;
                    Console.Clear();
                    break;
                default:
                    string valinv = "Valor invalido, Presiona enter.";
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (valinv.Length / 2)) + "}", valinv));
                    enter();
                    valid = true;
                    Console.Clear();
                    break;
            }
            return valid;
        }
        public void desarrollador()
        {
                string minombre = "Pablo Andrés Lutin Gomez";
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (minombre.Length / 2)) + "}", minombre));
                enter();
                string carrera = "Ingeniería en Sistemas";
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (carrera.Length / 2)) + "}", carrera));
                enter();
                string carne = "Carné: 160402009";
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (carne.Length / 2)) + "}", carne));
                enter();
            //--------------------------------------------------------------------------------------------------------------
                string minombre2 = "Axel David Colop Castro";
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (minombre2.Length / 2)) + "}", minombre2));
                enter();
                string carrera2 = "Ingeniería en Sistemas";
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (carrera2.Length / 2)) + "}", carrera2));
                enter();
                string carne2 = "Carné: 160402008";
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (carne2.Length / 2)) + "}", carne2));
                enter();
                string proyecto = "Proyecto Final Estructuras Logicas.";
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (proyecto.Length / 2)) + "}", proyecto));
                enter();
                Console.Clear();
        }
        public void instrucciones()
        {
            string titulo = "PROYECTO FINAL";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (titulo.Length / 2)) + "}", titulo));
            enter();
            string linea1 = "Esta es una calculadora capaz de reconocer singos positivos, negativos,";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (linea1.Length / 2)) + "}", linea1));
            string linea2 = "operaciones aritmeticas puedes relizar varias operaciones aritmeticas";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (linea2.Length / 2)) + "}", linea2));
            string linea3 = "y obtener los resultados exactos, tienes las operaciones de suma, resta,";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (linea3.Length / 2)) + "}", linea3));
            string linea4 = "multiplicacion y division. Tienes que presionar enter despues de cada caracter";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (linea4.Length / 2)) + "}", linea4));
            string linea5 = "que ingresas ya sea numero, operadores o signos de agrupación.";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (linea5.Length / 2)) + "}", linea5));
            enter();
            Console.Clear();
        }
        public void imprimir()
        {
            foreach (string s in array)
            {
                Console.WriteLine(s);
            }
        }
        public string peek()
        {
            string cadena = Convert.ToString(stack[top]);
            return cadena;
        }
        public bool isEmpty()
        {
            if (top == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isFull()
        {
            if (top == stack.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void push()
        {
            if (!isFull())
            {
                stack[top] = valor;
                top++;
            }
        }
        public void pop()
        {
            if (!isEmpty())
            {
                stack[top] = null;
                top--;
			}
        }

        //#############################################################################################################################
        public void calculadora(string[] array, string[] stack, string[] arraytemp)
        {
            for (nav = 0; validsub == true; nav++)
            {

                if (contador == 0)
                {
                    Console.WriteLine("Escribe un numero.");
                    foreach (string s in array)
                    {
                        Console.Write(s);
                    }
                    x = int.Parse(Console.ReadLine());

                    array[sum] = Convert.ToString(x);
                    sum++;
                    Console.Clear();
                    Console.WriteLine("ingresa el operador");
                    foreach (string s in array)
                    {
                        Console.Write(s);
                    }
                    signo = char.Parse(Console.ReadLine());
                    array[sum] = Convert.ToString(signo);
                    sum++;
                    foreach (string s in array)
                    {

                        Console.Write(s);
                    }
                    Console.Clear();
                    Console.WriteLine("Escribe un numero");
                    foreach (string s in array)
                    {
                        Console.Write(s);
                    }
                    y = int.Parse(Console.ReadLine());
                    array[sum] = Convert.ToString(y);
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
                    foreach (string s in array)
                    {
                        Console.Write(s);
                    }
                    signo = char.Parse(Console.ReadLine());
                    array[sum] = Convert.ToString(signo);
                    sum++;
                    Console.Clear();
                    if (signo == '=')
                    {
                        string resp = "La respuesta de";
                        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (resp.Length / 2)) + "}", resp));
                        foreach (string s in array)
                        {
                            Console.Write(s);
                        }
                        string es = "\nes: " + a;
                        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (es.Length / 2)) + "}", es));

                        enter();
                        Console.Clear();
                        validsub = salir(array, stack, arraytemp);
                        contador = contador - 1;
                    }
                    else
                    {
                        Console.WriteLine("Escribe un numero");
                        foreach (string s in array)
                        {
                            Console.Write(s);
                        }
                        y = int.Parse(Console.ReadLine());
                        array[sum] = Convert.ToString(y);
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
                                validsub = salir(array, stack, arraytemp);
                                break;
                        }
                    }
                }

            }

        }
        //###############################################################################################################################
        //---------------------------------------fin de clase-----------------------------------------------------------------------------------------------
    }
}
