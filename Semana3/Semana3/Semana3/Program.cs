﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validsub = true;
            bool valid = true;
            while (valid) {

                Console.WriteLine("Escoge la opcion depende de lo que quieras hacer.");
                Console.WriteLine(" 1. Ejercicio 1");
                Console.WriteLine(" 2. Ejercicio 2");
                Console.WriteLine(" 3. Ejercicio 3");
                Console.WriteLine(" 4. Ejercicio 4");
                Console.WriteLine(" 5. Ejercicio 5");
                Console.WriteLine(" 6. Ejercicio 6");
                Console.WriteLine(" 7. Ejercicio 7");
                Console.WriteLine(" 8. Ejercicio 8");
                Console.WriteLine(" 9. Ejercicio 9");
                Console.WriteLine(" 10. Ejercicio 10");
                Console.WriteLine(" 11. SALIR");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                // Menu

                switch (opcion)
                {
                    case 1:
                        while (validsub)
                        {
                            Console.WriteLine("Ingresa 2 numeros enteros:");
                            enter();
                            Console.WriteLine("numero 1: ");
                            int a1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("numero 2: ");
                            int a2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("presiona enter para ver si son iguales.");

                            if (a1==a2)
                            {
                                Console.WriteLine(a1+" es igual que "+a2);
                                enter();
                                Console.WriteLine("presiona enter para continuar.");
                                enter();
                                Console.Clear();

                                validsub = salida();
                            }
                        }
                        break;
                    case 2:
                        // Ejercicio 2
                        while (validsub)
                        {

                            Console.WriteLine("Coloca cualquier número y te diré si es par o impar.");
                            int numero1 = int.Parse(Console.ReadLine());
                            if ((numero1 % 2) == 0)
                            {
                                Console.WriteLine(numero1 + " Es par.");
                                enter();
                                Console.Clear();
                                validsub = salida();
                            }
                            else
                            {
                                Console.WriteLine(numero1 + " Es impar.");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                Console.Clear();
                                validsub = salida();
                            }
                        }
                        break;
                    case 3:
                        while (validsub)
                        {
                            Console.WriteLine("Coloca cualquier número y te diré si es positivo o negativo.");
                            int signo = int.Parse(Console.ReadLine());
                            if (signo > 0)
                            {
                                Console.WriteLine(signo + " Es positivo.");
                                enter();
                                Console.Clear();
                                validsub = salida();

                            }
                            else
                            {
                                Console.WriteLine(signo + " Es negativo.");
                                enter();
                                Console.Clear();
                                validsub = salida();
                            }
                        }
                        break;
                    case 4:
                        while (validsub)
                        {
                            Console.WriteLine("Introduce un año y te diré si es bisiesto o no");
                            int anio = Convert.ToInt32(Console.ReadLine());
                            if (anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0))
                            {
                                Console.WriteLine("El año " + anio + " Si es bisiesto ");
                                enter();
                                Console.Clear();
                                validsub = salida();
                            }
                            else
                            {
                                Console.WriteLine("El año " + anio + " No es bisiesto ");
                                enter();
                                Console.Clear();
                                validsub = salida();
                            }
                        }
                        break;
                    case 5:
                        while (validsub)
                        {
                            Console.WriteLine("Ingresa tu edad para comprobar si calificas para poder votar.");
                            int edad = int.Parse(Console.ReadLine());
                            if (edad >= 18)
                            {
                                Console.WriteLine("¡Felicidades! con " + edad + " años ya puedes votar.");
                                enter();
                                Console.Clear();
                                validsub = salida();
                            }
                            else
                            {
                                int restante = 18 - edad;
                                Console.WriteLine("Lastimosamente te faltan " + restante + " años para votar");
                                enter();
                                Console.Clear();
                                validsub = salida();
                            }
                        }
                        break;
                    case 6:
                        while (validsub)
                        {
                            Console.WriteLine("Coloca tu altura en centimetros y veremos de que altura eres.");
                            int altura = int.Parse(Console.ReadLine());
                            if (altura > 175)
                            {
                                Console.WriteLine("Eres una persona alta.");
                                enter();
                                Console.Clear();
                                validsub = salida();
                            }
                            else
                            {
                                if (altura < 175 && altura > 155)
                                {
                                    Console.WriteLine("eres una persona de estatura promedio.");
                                    enter();
                                    Console.Clear();
                                    validsub = salida();

                                }
                                else if (altura > 175)
                                {
                                    Console.WriteLine("eres una persona alta.");
                                    enter();
                                    Console.Clear();
                                    validsub = salida();
                                }
                                else
                                {
                                    Console.WriteLine("Eres una persona de estatura baja");
                                    enter();
                                    Console.Clear();
                                    validsub = salida();
                                }
                            }
                        }
                        break;
                    case 7:
                        while (validsub)
                        {

                            Console.WriteLine("Vamos a ingresar 3 numeros y definir cual tiene mayor valor.");
                            Console.WriteLine("Ingresa el primer numero");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el segundo numero");
                            int num2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el tercer numero.");
                            int num3 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Presiona enter para ver el resultado.");
                            enter();
                            Console.Clear();

                            if (num1>num2&&num1>num3)
                            {
                                Console.WriteLine(num1+" Es mayor que "+num2+" y "+num3);
                                Console.WriteLine("Presiona enter para continuar.");
                                enter();
                                Console.Clear();
                                validsub = salida();
                            }else if (num2>num1&&num2>num3)
                            {
                                Console.WriteLine(num2 + " Es mayor que " + num1 + " y " + num3);
                                Console.WriteLine("Presiona enter para continuar.");
                                enter();
                                Console.Clear();
                                validsub = salida();
                            }
                            else
                            {
                                Console.WriteLine(num3 + " Es mayor que " + num1 + " y " + num2);
                                Console.WriteLine("Presiona enter para continuar.");
                                enter();
                                Console.Clear();
                                validsub = salida();
                            }
                            
                        }                        
                        break;
                    case 8:
                        while (validsub)
                        {
                            Console.WriteLine("Ingresa datos y calificaciones de un alumno.");
                            Console.WriteLine("\nCodigo de alumno:");
                            int codigo = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nombre del alumno:");
                            string nomal = Console.ReadLine();
                            Console.WriteLine("Nota de Fisica:");
                            float fisica = float.Parse(Console.ReadLine());
                            Console.WriteLine("Nota de  Quimica:");
                            float quimica = float.Parse(Console.ReadLine());
                            Console.WriteLine("Nota de Programacion:");
                            float progra = float.Parse(Console.ReadLine());
                            Console.WriteLine("Presiona enter para ver resultados.");
                            enter();
                            Console.Clear();

                            Console.WriteLine("Codigo de alumno: "+codigo);
                            Console.WriteLine("Nombre de Alumno: "+nomal);
                            Console.WriteLine("Nota de Fisica: " + fisica + "\nNota de Quimica: " + quimica + "\nNota de Programamcion: " + progra);
                            float total = fisica + quimica + progra;
                            float promedio = total / 3; 
                            Console.WriteLine("\nNota Total: "+total);
                            Console.WriteLine("\nPromedio: "+promedio);
                            Console.WriteLine("\nPresiona enter para continuar.");
                            enter();
                            Console.Clear();

                            validsub = salida();
                        }                        
                        break;
                    case 9:
                        while (validsub)
                        {
                            Console.WriteLine("Ok, vamos a ver como está la temperatura del ambiente y determinar que tipo de clima hay.");
                            enter();
                            Console.WriteLine("Ingresa la temperatura en grados centigrados");
                            float grados = float.Parse(Console.ReadLine());
                            if (grados<0)
                            {
                                Console.WriteLine("con "+grados+" Centigrados, El clima está para congelarse");
                                Console.WriteLine("presiona enter para continuar.");
                                enter();
                                Console.Clear();
                                validsub = salida();
                            }else if (0<=grados&&grados<=10)
                            {
                                Console.WriteLine("con " + grados + " Centigrados, El clima está muy frío");
                                Console.WriteLine("presiona enter para continuar.");
                                enter();
                                Console.Clear();
                                validsub = salida();
                            }
                            else if (10<grados&&grados<=20)
                            {
                                Console.WriteLine("con " + grados + " Centigrados, El clima está frio");
                                Console.WriteLine("presiona enter para continuar.");
                                enter();
                                Console.Clear();
                                validsub = salida();
                            }
                            else if (20<grados&&grados<=30)
                            {
                                Console.WriteLine("con " + grados + " Centigrados, El clima está normal");
                                Console.WriteLine("presiona enter para continuar.");
                                enter();
                                Console.Clear();
                                validsub = salida();
                            }else if (30<grados&&grados<40)
                            {
                                Console.WriteLine("con " + grados + " Centigrados, El clima está caliente");
                                Console.WriteLine("presiona enter para continuar.");
                                enter();
                                Console.Clear();
                                validsub = salida();
                            }else if (grados>=40)
                            {
                                Console.WriteLine("con " + grados + " Centigrados, El clima está muy caliente");
                                Console.WriteLine("presiona enter para continuar.");
                                enter();
                                Console.Clear();
                                validsub = salida();
                            }
                            else
                            {
                                Console.WriteLine("Invalido, intenta de nuevo.");
                                Console.WriteLine("presiona enter para continuar.");
                                enter();
                                Console.Clear();
                                validsub = salida();
                            }
                        }
                        break;
                    case 10:
                        while (validsub)
                        {
                            caracter c = new caracter();
                            char Car;
                            Console.WriteLine("Ingresa cualquier letra");
                            Car = Convert.ToChar(Console.ReadLine());
                            c.Calcula(Car);
                            Console.WriteLine("Presiona enter para continuar.");
                            enter();
                            Console.Clear();

                            validsub = salida();
                            
                        }
                        break;
                    case 11:
                        Console.WriteLine("¿Quieres salir?\n 1. Si\n 2. No");
                        int salir = int.Parse(Console.ReadLine());
                        switch (salir)
                        {
                            case 1:
                                Console.WriteLine("Presiona enter para salir.");
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
                                Console.WriteLine("Selección invalida.\nPresiona enter para continuar.");
                                enter();
                                Console.Clear();
                                valid = true;
                                break;
                        }
                        break;
                    case 12:
                        Console.WriteLine("¿Quieres Salir?\n 1. Si\n 2. No");
                        int sal = int.Parse(Console.ReadLine());

                        switch (sal)
                        {
                            case 1:
                                Console.WriteLine("Presiona enter para salir.");
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
                                Console.WriteLine("Selección invalida.\nPresiona enter para retornar.");
                                enter();
                                Console.Clear();
                                valid = true;
                                break;
                        }
                        break;
                    default:
                            Console.WriteLine("seleccion invalida.\nPresiona enter para continuar");
                            enter();
                            Console.Clear();
                            valid = true;
                        break;
                }
            }
        }
        static bool salida()
        {
            bool validsub = true;
            Console.WriteLine("¿Quieres intentar de nuevo?\n 1. Si\n 2. No");
            int salida = int.Parse(Console.ReadLine());

            switch (salida)
            {
                case 1:

                    Console.WriteLine("Prsiona enter para retornar.");
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

                    Console.WriteLine("Selección invalida, presiona enter para continuar.");
                    enter();
                    Console.Clear();
                    validsub = true;

                    break;
            }
            return validsub;
        }
        static void enter()
        {
            while(Console.ReadKey().Key != ConsoleKey.Enter){ }
        }
    }

    class caracter
    {
        public void Calcula(char Car)
        {
            switch (Car)
            {
                case 'a':
                    Console.WriteLine("'"+Car+"' es vocal");
                    break;
                case 'e':
                    Console.WriteLine("'" + Car + "' es vocal");
                    break;
                case 'i':
                    Console.WriteLine("'" + Car + "' es vocal");
                    break;
                case 'o':
                    Console.WriteLine("'" + Car + "' es vocal");
                    break;
                case 'u':
                    Console.WriteLine("'" + Car + "' es vocal");
                    break;
                default:
                    Console.WriteLine("'" + Car + "' es consonante");
                    break;
            }
        }
    }
}
