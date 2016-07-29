using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios11Al14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio

            Console.WriteLine("¡Hola!, ingresa tu nombre.");
            string nombre = Console.ReadLine();
            Console.Clear();

            //Validación

            bool valid = true;
            while (valid) {

                // Listado
                Console.WriteLine("está bien, " + nombre + " escribe el numero según lo que quieras hacer.");
                Console.WriteLine(" 1. Ejercicio 11");
                Console.WriteLine(" 2. Ejercicio 12");
                Console.WriteLine(" 3. Ejercicio 13");
                Console.WriteLine(" 4. Ejercicio 14");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion) {

                    case 1:

                        //Ejercicio 11
                        Console.WriteLine("Ingresa tu edad:");
                        int edad = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("¿En serio?, pues te ves mayor de " + edad + " años");
                        Console.WriteLine("Presiona enter para volver al menú.");
                        Console.ReadKey();
                        Console.Clear();
                        opcion = 0;
                        valid = true;

                        break;
                    case 2:

                        Console.WriteLine("Escribe un número para que pueda repetirlo de diferentes formas.");
                        int num1 = int.Parse(Console.ReadLine());
                        int incremento = 0;
                        Console.Clear();
                        Console.WriteLine("Esta es mi repetición..");
                        Console.WriteLine(" ");

                        while (valid)
                        {
                            if(incremento <= 2)
                            {
                                Console.WriteLine(num1+" "+num1+" "+num1+" "+num1);
                                Console.WriteLine(num1+""+num1+""+num1+""+num1);
                                incremento++;
                                Console.WriteLine(" ");
                                Console.WriteLine("Presiona enter para volver al menú.");
                                Console.ReadKey();
                                Console.Clear();
                                opcion = 0;
                                valid = true;
                            }
                            else
                            {
                                Console.WriteLine("ERROR.");
                                Console.ReadKey();
                                Console.Clear();
                                valid = true;
                            }
                        }


                        break;
                    case 3:

                        Console.WriteLine("Escribe un número para que pueda dibujar con él");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Esta es mi dibujo..");
                        Console.WriteLine(" ");
                        Console.WriteLine(num2+""+num2+""+num2);
                        Console.WriteLine(num2+"  "+num2);
                        Console.WriteLine(num2 + "  " + num2);
                        Console.WriteLine(num2 + "" + num2 + "" + num2);
                        Console.WriteLine(" ");
                        Console.WriteLine("Presiona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        opcion = 0;
                        valid = true;

                        break;
                    case 4:

                        Console.WriteLine("Ok, "+nombre+" vamos a hacer conversiones de grados.");
                        Console.WriteLine("\nSelecciona el tipo de dato que ingresaras.");
                        Console.WriteLine(" 1. Grados Celsius\n 2. Grados Kelvin\n 3. Grados Fahrenheit\n 4. Salir");
                        int dato = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (dato)
                        {
                            case 1:

                                Console.WriteLine("Ingresa los grados en Celsius para convertir:");
                                float c = float.Parse(Console.ReadLine());
                                double ck = c+273;
                                Console.WriteLine(c+" grados celsius convertidos a Kelvin son: "+ck);
                                double cf = c * 1.8 + 32;
                                Console.WriteLine(c + " grados celsius convertidos a Farenheith son: " + cf);

                                break;
                            case 2:

                                Console.WriteLine("Ingresa los grados en Kelvin para convertir:");
                                float k = float.Parse(Console.ReadLine());
                                double kc = k - 273;
                                Console.WriteLine(k + " grados Kelvin convertidos a Celsius son: " + kc);
                                double kf = kc * 1.8 + 32;
                                Console.WriteLine(k + " grados Kelvin convertidos a Farenheith son: " + kf);

                                break;
                            case 3:

                                Console.WriteLine("Ingresa los grados en Farenheith para convertir:");
                                float f = float.Parse(Console.ReadLine());
                                double fc = (f - 32)/1.80;
                                Console.WriteLine(f + " grados Farenheith convertidos a Celsius son: " + fc);
                                double fk = fc + 273;
                                Console.WriteLine(f + " grados Farenheith convertidos a Kelvin son: " + fk);

                                break;
                            case 4:

                                Console.WriteLine("Presiona enter para salir");
                                Console.ReadKey();
                                Console.Clear();
                                opcion = 0;
                                dato = 0;
                                valid = true;

                                break;
                            default:

                                Console.WriteLine("Selección invalida\nPresiona enter para continuar");
                                Console.ReadKey();
                                Console.Clear();
                                opcion = 0;
                                dato = 0;
                                valid = true;

                                break;
                        }

                        break;
                    case 5:
                        break;
                    default:

                        Console.WriteLine("Selección invalida.\nPresiona enter para volver al menu.");
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