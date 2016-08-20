using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 0;
            int num = 0;

            int[] arreglo = new int[42];

           // if (a <= 41)
            //{
                for (num = 0; a <= 41; num = num + 10)
                {
                    arreglo[a] = num;
                    Console.WriteLine("numero " + num + " insertado");
                    Console.ReadKey();
                    a = a + 1;
                }

            Console.WriteLine("Ya llegue a 42 registros. Array lleno");
            
            Console.WriteLine(" ");
            Console.ReadKey();
            Console.WriteLine("al imprimir el arreglo queda así: ");
            foreach(int s in arreglo)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
            */

            // iniciar arreglo
            string[] datos = new string[10];
            // ingresar nombres sin repetidos
            int navegador = 0;
            int contador = 0;
            while (contador <= 9)
            {
                Console.WriteLine("ingresa un nombre: ");
                string nombre = Console.ReadLine();

                int nada = 0;

                    if (datos[nada] == nombre)
                    {
                        Console.WriteLine("Este nombre ya existe.");
                    }
                    else
                    {
                        datos[navegador] = nombre;
                        contador = contador + 1;
                        navegador = navegador + 1;
                        Console.WriteLine("El nombre " + nombre + " se ha ingresado exitosamente.");
                    }
                
            }
            // Imprimir lista
            Console.WriteLine("La lista quedó así:");

            foreach (string s in datos)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
            //borrar 5to registro
            Console.WriteLine("ahora presiona cualquier tecla para borrar el quinto registro.");
            Console.ReadKey();
            int quinto = 4;
            int sum = 0;
            
            for(sum =0;sum <= quinto; sum++)
            {
                if (sum == quinto)
                {
                    datos[sum] = null;
                    Console.WriteLine("El 5to registro se ha eliminado.");
                }
            }
            
            Console.ReadKey();
            // Vuelvo a imprimir
            Console.WriteLine("Ya sin el 5to registro la lista queda así");
            foreach (string s in datos)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
            // actualizar ultimo registro
            Console.WriteLine("Vamos a actualizar el ultimo nombre");
            Console.WriteLine("ingresa un nuevo nombre: ");
            string nuevonombre = Console.ReadLine();
            int ultimo = 9;
            for (sum = 0; sum <= ultimo; sum++)
            {
                if (sum == ultimo)
                {
                    datos[sum] = nuevonombre;
                    Console.WriteLine("El ultimo registro se ha actualizado.");
                }
            }
            // imprimir de nuevo
            Console.WriteLine("la lista quedó asi.");
            Console.WriteLine(" ");
            foreach (string s in datos)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
