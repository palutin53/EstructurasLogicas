using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1Al6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1//
            Console.WriteLine("¡Hola! Ingresa Tu Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("¡Hola: " + nombre + "!");
            Console.WriteLine("Presiona enter para comenzar");
            Console.ReadLine();
            Console.Clear();
            //Ejercicio 2//
            Console.WriteLine("Bien, vamos a hacer una suma.");
            Console.WriteLine("Ingresa un numero: ");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero: ");
            float numero2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ahora presiona enter");
            Console.ReadKey();
            float suma = numero1 + numero2;
            Console.WriteLine("Al sumar " + numero1 + " y " + numero2 + " El resultado es: " + suma);
            Console.ReadKey();
            Console.Clear();
            //Ejercicio 3//
            Console.WriteLine("Bien, Ahora vamos a hacer una division.");
            Console.WriteLine("Ingresa un numero: ");
            float div1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero: ");
            float div2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ahora presiona enter");
            Console.ReadKey();
            float division = div1 / div2;
            Console.WriteLine("Al dividir " + div1 + " entre " + div2 + " El resultado es: " + division);
            Console.ReadKey();
            Console.Clear();
            //Ejercicio 4//
            Console.WriteLine("Ok, ahora te voy a demostrar que puedo resolver varias operaciones.");
            //----------------1
            Console.WriteLine("Presiona enter para ver el resultado de -1+3*5");
            Console.WriteLine("Ahora presiona enter");
            Console.ReadLine();
            double op1 = -1 + (3 * 5);
            Console.WriteLine("El resultado es: " + op1);
            Console.ReadKey();
            Console.Clear();
            //---------------2
            Console.WriteLine("Presiona enter para ver el resultado de (24+5)7%");
            Console.ReadLine();
            double op2 = (24 + 5) * 0.07;
            Console.WriteLine("El resultado es: " + op2);
            Console.ReadKey();
            Console.Clear();
            //---------------3 
            Console.WriteLine("Presiona enter para ver el resultado de 15+-4*6/11");
            Console.ReadLine();
            double op3 = 15 + (-4 * (6 / 11));
            Console.WriteLine("El resultado es: " + op3);
            Console.ReadKey();
            Console.Clear();
            //---------------------4
            Console.WriteLine("Presiona enter para ver el resultado de 2+10/6*1-7%2");
            Console.ReadLine();
            double op4 = 2 + ((10 / 6) * 1) - ((0.07) * 2);
            Console.WriteLine("El resultado es: " + op4);
            Console.ReadKey();
            Console.Clear();
            //Ejercicio 5//
            Console.WriteLine("Muy bien, ahora vamos a intercambiar el orden de algunos numeros");
            Console.WriteLine("Ingresa el primer numero: ");
            float intercambio1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ahora un segundo número: ");
            float intercambio2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Los numeros como los ingresaste son: " + intercambio1 + " y " + intercambio2);
            Console.WriteLine("Ahora presiona enter par intercambiarlos");
            Console.ReadLine();
            Console.WriteLine("Los numeros intercambiados quedan así: " + intercambio2 + " y " + intercambio1);
            Console.ReadKey();
            Console.Clear();
            //Ejercicio 6//
            Console.WriteLine("Ok, Ahora intentemos algo más dificil, una multiplicación de 3 numeros.");
            Console.WriteLine("Presiona enter cuando esés listo.");
            Console.ReadKey();
            Console.WriteLine("Ingresa el primer numero: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Un segundo numero: ");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Por último un tercer número: ");
            float num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ok, espero recordar los 3 números... los numeros que ingresaste son: " + num1 + " , " + num2 + " y si mal no recuerdo " + num3);
            Console.WriteLine("Muy bien, ahora presiona enter y veremos el resultado de " + num1 + " X " + num2 + " X " + num3);
            Console.ReadKey();
            float multri = num1 * num2 * num3;
            Console.WriteLine("El resultado es: " + multri + ", ¿Correcto?");
            Console.WriteLine("¡Muy bien! " + nombre + " Fue divertido pero este es el final de mi codigo.");
            Console.WriteLine("pero si quieres presiona un último enter.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
