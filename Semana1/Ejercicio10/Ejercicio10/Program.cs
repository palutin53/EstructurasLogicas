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
            Console.WriteLine("Presiona enter para ver el resultado.");
            Console.ReadKey();
            float op = (x + y) * z;
            Console.WriteLine("\nMuy bien ahora con esos 3 valores vamos a operar ("+x+" + "+y+") * "+z+" y el resultado es: "+op);
            Console.WriteLine("");
        }
    }
}
