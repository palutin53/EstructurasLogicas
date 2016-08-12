using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicio

            Console.WriteLine("¡Hola! ingresa tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("¡Hola! " + nombre + " presiona enter para continuar");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();

            //Validación de repeticion

            bool valid = true;
            while (valid)
            {
                
                //Menú

                int opcion = 0;
                Console.WriteLine("Escoge la opcion que desees utilizar:");
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
                Console.WriteLine(" 11. Ejercicio 11");
                Console.WriteLine(" 12. SALIR.");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                //validacion para sub-menu
                bool validsub = true;

                switch (opcion)
                {
                    
                    case 1:

                        //Ejercicio 1

                        while (validsub)
                        {

                            Console.WriteLine("Ingresa 3 letras y le cambiaremos el orden.");
                            Console.WriteLine("Ingresa la primera letra:");
                            string letra1 = Console.ReadLine();
                            Console.WriteLine("Ingresa la segunda letra:");
                            string letra2 = Console.ReadLine();
                            Console.WriteLine("Ingresa la tercera letra:");
                            string letra3 = Console.ReadLine();
                            Console.WriteLine("Presiona enter para ver el orden inverso.");
                            enter();
                            Console.WriteLine("La cadena quedan así: " + letra3 + "  " + letra2 + "  " + letra1);
                            enter();
                            Console.Clear();

                            validsub = salir();

                        }

                        break;
                    case 2:

                        // Ejercicio 2

                        while (validsub)
                        {

                            int num, lineas, ancho;
                            Console.WriteLine("Introduzca un numero de 1 a 9 para crear un triangulo.");
                            num = int.Parse(Console.ReadLine());
                            Console.Clear();
                            for (lineas = 1; lineas <= num; lineas++)
                            {
                                for (ancho = 0; ancho <= num - lineas; ancho++)
                                {
                                    Console.Write(num);
                                }
                                Console.WriteLine();
                            }
                            enter();
                            Console.Clear();

                            validsub = salir();

                        }

                        break;
                    case 3:

                        while (validsub)
                        {
                            int login = 1;
                        for (login = 1; login <= 3; login++)
                        {
                            Console.WriteLine("¡Bienvenido! Ingresa tu contraseña: ");
                            Console.ReadLine();
                            Console.WriteLine("Contraseña incorrecta.");
                            enter();
                            Console.Clear();
                        }

                            validsub = salir();

                        }
                        break;
                    case 4:

                        while (validsub)
                        {

                            Console.WriteLine("Ok, vamos a hacer operaciones aritmeticas, ingresa los numeros y la operacion (+ , - , * , /) que desees realizar.");
                            Console.WriteLine("Presiona enter cuando estés listo.");
                            enter();
                            Console.Clear();
                            Console.WriteLine("Recuerda que puedes hacer 4 básicas operaciones (+ , - , * , / ).");
                            enter();
                            Console.WriteLine("Ok, ahora ingresa el primer numero para operar.");
                            double num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("¿Qué operación quieres realizar?.");
                            char op = char.Parse(Console.ReadLine());
                            Console.WriteLine("Y el segundo numero.");
                            double num2 = int.Parse(Console.ReadLine());

                            if (op == '+' || op == '-' || op == '*' || op == '/')
                            {
                                if(op == '+')
                                {
                                    double suma = num1 + num2;
                                    Console.WriteLine("El resultado de "+num1+" "+op+" "+num2+" es: "+suma);
                                    enter();
                                    Console.Clear();
                                }
                                else { }
                                if (op == '-')
                                {
                                    double resta = num1 - num2;
                                    Console.WriteLine("El resultado de " + num1 + " " + op + " " + num2 + " es: " + resta);
                                    enter();
                                    Console.Clear();
                                }
                                else { }
                                if (op == '*')
                                {
                                    double multi = num1 * num2;
                                    Console.WriteLine("El resultado de " + num1 + " " + op + " " + num2 + " es: " + multi);
                                    enter();
                                    Console.Clear();
                                }
                                else { }
                                if (op == '/')
                                {
                                    double div = num1 / num2;
                                    Console.WriteLine("El resultado de " + num1 + " " + op + " " + num2 + " es: " + div);
                                    enter();
                                    Console.Clear();
                                }
                                else { }
                            }
                            else
                            {
                                Console.WriteLine("Operador incorrecto.");
                                enter();
                                Console.Clear();
                                validsub = true;
                            }

                            validsub = salir();
                        }

                        break;
                    case 5:

                        while (validsub)
                        {

                            Console.WriteLine("Muy bien " + nombre + " vamos a calcular el area y perimetro de un circulo.");
                            Console.WriteLine("presiona enter para empezar.");
                            enter();
                            Console.Clear();

                            // Variables necesarias
                            double pi = Math.PI;

                            Console.WriteLine("Necesitamos los siguientes datos:");
                            Console.WriteLine("Radio del circulo:");
                            double radio = int.Parse(Console.ReadLine());
                            Console.WriteLine("Presiona enter para ver los resultados");
                            enter();
                            double perimetro = (2 * pi) * radio;
                            double radio2 = Math.Pow(radio, 2);
                            double area = pi * radio2;
                            Console.WriteLine("El perimetro de el circulo es: " + perimetro);
                            Console.WriteLine("Y el area del ciculo es : " + area);
                            enter();
                            Console.Clear();

                            validsub = salir();

                        }
                        
                        break;
                    case 6:

                        while (validsub)
                        {

                            Console.WriteLine("Muy bien, vamos a trabajar con funciones...");
                            enter();
                            Console.WriteLine("vamos a examinar los valores de la funcion x = y^2 + 2y + 1");
                            enter();
                            Console.WriteLine("Puedes utilizar valores enteros de -5 hasta 5, ¿Listo?");
                            enter();
                            Console.WriteLine("Ok, ingresa el valor para Y entre -5 y 5 que quieras colocar en la funcion.");
                            int y = int.Parse(Console.ReadLine());
                            Console.Clear();

                            if ((y >= (-5) && y <= 5) || (y>=(-5)&&y<=5))
                            {
                                Console.WriteLine("Ok, Sustituyendo el numero "+y+ " en la funcion x = y^2 + 2y + 1");
                                Console.WriteLine("Presiona enter para ver el resultado.");
                                enter();
                                double y2 = Math.Pow(y, 2);
                                double x = y2 + (2*y) + 1;
                                Console.WriteLine("El valor de X cuando Y es: "+y+" es:"+x);
                                enter();
                                Console.Clear();

                                validsub = salir();
                            }
                            else
                            {
                                Console.WriteLine("Has ingresado un numero que está fuera de rango");
                                Console.WriteLine("recuerda que es solo entre -5 y 5, presiona enter para intentarlo de nuevo");
                                enter();
                                Console.Clear();

                                validsub = salir();
                            }
                        }

                        break;
                    case 7:

                        while (validsub)
                        {
                            Console.WriteLine("Muy bien " + nombre + " vamos a calcular la velocidad en kilómetros por hora y millas por hora con los datos que me proporciones.");
                            enter();
                            Console.WriteLine("Ok, necesitare los siguientes datos...");
                            enter();
                            Console.WriteLine("Ingresa los kilometros recorridos: ");
                            double d = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ahora ingresa el tiempo (en horas) en que se recorrieron: ");
                            double t = int.Parse(Console.ReadLine());
                            double kmh = d / t;
                            Console.WriteLine("La velocidad en Kilometros/hora es: " + kmh + " Km/h.");
                            enter();
                            double dm = d * 0.621371;
                            double mih = dm / t;
                            Console.WriteLine("y la velocidad en Millas/hora es: " + mih + " Mi/h.");
                            enter();
                            Console.Clear();

                            validsub = salir();

                        }

                        break;
                    case 8:
                        while (validsub)
                        {

                            Console.WriteLine("Ok, en ese ejercicio con los datos que me proporciones vamos a obtener datos de una esfera.");
                            enter();
                            Console.WriteLine("Ok, necesito que introduzcas el radio de una esfera: ");
                            double r = int.Parse(Console.ReadLine());
                            Console.WriteLine("presiona enter para obtener los resultados.");
                            enter();
                            double pi = Math.PI;
                            double r2 = Math.Pow(r, 2);
                            double area = 2 * pi * r2;
                            Console.WriteLine("El area de una esfera de radio "+r+" es: "+area);
                            enter();
                            double r3 = Math.Pow(r, 3);
                            double volumen = (4 / 3) * pi * r3;
                            Console.WriteLine("El volumen de una esfera de radio "+r+" es: "+volumen);
                            enter();
                            Console.Clear();

                            validsub = salir();

                        }

                        break;
                    case 9:

                        while (validsub)
                        {

                            string input = string.Empty;

                            Console.WriteLine("Ok, vamos a diferenciar numeros y letras");
                            enter();

                            //Solicitar el dato
                            Console.WriteLine("Ingresa numeros o letras");
                            input = Console.ReadLine();

                            //Llamar metodo que evalua los caracteres
                            if (IsLetters(input))
                            {
                                Console.WriteLine("Los caracteres son letras.");
                            }
                            else
                            {
                                Console.WriteLine("Los caracteres son numeros");
                            }
                            enter();
                            Console.Clear();

                            validsub = salir();
                        }

                        break;
                    case 10:

                        while (validsub)
                        {
                           
                            Console.WriteLine("Ok, vamos a ingresar 2 valores, cuando ambos numeros sean pares aparecera 'Verdadero' y 'Falso' cuando ambos sean impares");
                            enter();
                            Console.WriteLine("Ingresa el valor 1: ");
                            int valor1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el valor 2: ");
                            int valor2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("presiona enter para ver el resultado.");
                            enter();
                            Console.Clear();

                            if (((valor1 % 2) == 0)&&((valor2 % 2) == 0))
                            {
                                Console.WriteLine("Verdadero.");
                            }
                            else
                            {
                                Console.WriteLine("Falso.");
                            }

                            enter();
                            Console.Clear();

                            validsub = salir();

                        }

                        break;
                    case 11:

                        while (validsub)
                        {
                            Console.WriteLine("Ok, en esta ocacion convertiremos numeros decimales a binarios.");
                            enter();
                            Console.WriteLine("Ingresa un numero decimal positivo: ");
                            int dec = Convert.ToInt32(Console.ReadLine());
                            string bin = "";

                            if (dec > 0)
                            {
                                while(dec > 0)
                                {
                                    if (dec % 2 == 0)
                                    {
                                        bin = "0" + bin;
                                    }
                                    else
                                    {
                                        bin = "1" + bin;
                                    }
                                    dec = (int)dec / 2;
                                }
                            }else if (dec == 0)
                            {
                                bin = "0";
                            }else
                            {
                                bin = "No se pudo Convertir. Ingresa un numero positivo.";
                            }
                            Console.WriteLine("El resultado de la conversión: "+bin);
                            Console.ReadLine();                          
                        }

                        enter();
                        Console.Clear();

                        salir();

                        break;
                    case 12:

                        Console.WriteLine("¿Quieres salir?\n 1. Si\n 2. No");
                        int salida = int.Parse(Console.ReadLine());

                        switch (salida)
                        {
                            case 1:
                                Console.WriteLine("presiona enter para salir.");
                                enter();
                                valid = false;
                                Console.Clear();
                                break;
                            case 2:
                                Console.WriteLine("Presiona enter para retornar");
                                enter();
                                valid = true;
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Seleccion invalida, presiona enter.");
                                enter();
                                valid = true;
                                Console.Clear();
                                break;
                        }

                        break;
                    default:

                        Console.WriteLine("el valor que ingresaste no es valido.");
                        enter();
                        Console.WriteLine("Presiona enter para volver al menu.");
                        enter();
                        Console.Clear();
                        valid = true;

                        break;
                }
            }
        }

        // Funcion de recepcion letras/numeros
        static bool IsLetters(string sCaracteres)
        {
            foreach (char ch in sCaracteres)
            {
                if (!Char.IsLetter(ch) && ch != 32)
                {
                    return false;
                }
            }
            return true;
        }

        // funcion enter

        static void enter()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

        //Funcion salir 

        static bool salir()
        {

            bool validsub;
            Console.WriteLine("¿Quieres intentar de nuevo?\n 1. Si\n 2. No");
            int salir = int.Parse(Console.ReadLine());
                        
            switch (salir)
            {
                case 1:
                    Console.WriteLine("presiona enter para retornar.");
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
                    Console.WriteLine("Selección invalida.");
                    enter();
                    Console.Clear();
                    validsub = true;
                    break;
            }
            return validsub;
        }

    }
}