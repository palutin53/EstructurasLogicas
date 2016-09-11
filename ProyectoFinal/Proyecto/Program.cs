using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {

            bool valid = true;
            Stack datos = new Stack();
            string[] numeros = new string[100];
            string[] operadores = new string[100];
            

            while (valid) {
                
                bool validsub = true;
                int nav = 0, e;
                double a = 0, x, y;
                int contador = 0, sum = 0;
                char signo;

                string menu = "Selecciona según lo que quieras hacer:";
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (menu.Length / 2)) + "}", menu));
                Console.WriteLine("\n 1. Instrucciones\n 2. Calculadora\n 3. Desarrollador \n 4. SALIR");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        while (validsub)
                        {
                            string titulo = "PROYECTO FINAL";
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (titulo.Length / 2)) + "}", titulo));
                            enter();
                            string linea1 = "Esta es una calculadora capaz de reconocer singos positivos, negativos,";
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (linea1.Length / 2)) + "}", linea1));
                            string linea2 = "operaciones aritmeticas puedes relizar varias operaciones aritmeticas";
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (linea2.Length / 2)) + "}", linea2));
                            string linea3  = "y obtener los resultados exactos, tienes las operaciones de suma, resta,";
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (linea3.Length / 2)) + "}", linea3));
                            string linea4 = "multiplicacion y division. Tienes que presionar enter despues de cada caracter";
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (linea4.Length / 2)) + "}", linea4));
                            string linea5 = "que ingresas ya sea numero, operadores o signos de agrupación.";
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (linea5.Length / 2)) + "}", linea5));
                            enter();
                            Console.Clear();
                            validsub = salir(numeros);
                        }                        
                        break;
                    case 2:
                        //----------------------------------------------------------------------------------------------------------------
                        while (validsub)
                        {
                            for (nav = 0; nav < 100; nav++)
                            {
                                Console.WriteLine("Ingresa la operación a evaluar.");
                                foreach (string s in numeros)
                                {
                                    Console.Write(s);
                                }
                                var valor = Console.ReadLine();
                                numeros[nav] = valor;
                                Console.Clear();
                                e = Int32.Parse(numeros[nav]);
                                if (e == '[' || e == ']' || e == '{' || e == '}' || e == '(' || e == ')')
                                {

                                }
                            }
                        }
                        //----------------------------------------------------------------------------------------------------------------
                        break;
                    case 3:
                        while (validsub)
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
                            string proyecto = "Proyecto Final Estructuras Logicas.";
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (proyecto.Length / 2)) + "}", proyecto));
                            enter();
                            Console.Clear();
                            validsub = salir(numeros);
                        }
                        break;
                    case 4:
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
        static bool salir(string[] numeros)
        {
            int borrar = 0;
            bool validsub = true;
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
                    validsub = true;
                    for (borrar = 0; borrar < 100; borrar++)
                    {
                        numeros[borrar] = null;
                    }
                    Console.Clear();
                    break;
                case 2:
                    string sali = "Presiona enter para salir.";
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (sali.Length / 2)) + "}", sali));
                    enter();
                    validsub = false;
                    for (borrar = 0; borrar < 100; borrar++)
                    {
                        numeros[borrar] = null;
                    }
                    Console.Clear();
                    break;
                default:
                    string inval = "Valor invalido, Presiona enter.";
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (inval.Length / 2)) + "}", inval));
                    enter();
                    validsub = false;
                    for (borrar = 0; borrar < 100; borrar++)
                    {
                        numeros[borrar] = null;
                    }
                    Console.Clear();
                    break;
            }
            return validsub;
        }
    }
}