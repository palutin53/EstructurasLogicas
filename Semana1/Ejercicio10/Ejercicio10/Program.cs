using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicio
            Console.WriteLine("¡Hola! Ingresa Tu Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("¡Hola: " + nombre + "!");
            Console.WriteLine("Presiona enter para comenzar");
            Console.ReadLine();
            Console.Clear();

            //Validación
            bool valid = true;
            while (valid) { 

            //Ejercicio10
            Console.WriteLine("Muy bien, " + nombre + " vamos a tomar 3 numeros y colocarlos en la misma operación, con y sin signos de agrupación");
            Console.WriteLine(" y verás que (X + Y)*Z al igual que X + Y * Z nos retornara exactamente el mismo resultado.");
            Console.WriteLine("\npresiona enter para empezar.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ingresa el número para X: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el número para Y: ");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el número para Z: ");
            float z = float.Parse(Console.ReadLine());
            Console.WriteLine("Presiona enter para ver el resultado de la forma (X + Y)*Z.");
            Console.ReadKey();
            float op = (x + y) * z;
            Console.WriteLine("\nMuy bien ahora con esos 3 valores vamos a operar ("+x+" + "+y+") * "+z+" y el resultado es: "+op+" \n\npresiona enter par continuar.");
            Console.ReadKey();
            Console.WriteLine("Ahora presiona enter para ver el resultado de la forma X + Y * Z");
            Console.ReadKey();
            float op2 = x+y*z;
            Console.WriteLine("\n\nMuy bien ahora con esos 3 valores vamos a operar " + x + " + " + y + " * " + z + " y el resultado es: " + op);
            Console.WriteLine("Presiona enter para continuar.");
            Console.ReadKey();
            Console.WriteLine("¿Quieres intentar de nuevo con otros numeros?\n 1.Si\n 2.No");
            int repetir = int.Parse(Console.ReadLine());
                switch (repetir)
                {
                    case 1:
                        Console.WriteLine("Presiona enter para continuar.");
                        repetir = 0;
                        valid = true;
                        break;
                    case 2:
                        Console.WriteLine("FIN DEL PROGRAMA");
                        Console.ReadKey();
                        valid = false;
                        break;
                    default:
                        Console.WriteLine("Selección invalida.\nPresiona enter para continuar.");
                        Console.ReadKey();
                        repetir = 0;
                        valid = true;
                        break;
                }
            }
        }
    }
}
