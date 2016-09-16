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
            string[] array = new string[100], stack = new string[100], arraytemp = new string[100];
            back fondo = new back();
            bool valid = true;
            while (valid) {

                string menu = "Selecciona según lo que quieras hacer:";
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (menu.Length / 2)) + "}", menu));
                Console.WriteLine("\n 1. Instrucciones\n 2. Calculadora\n 3. Desarrolladores \n 4. SALIR");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                bool validsub = true;

                switch (opcion)
                {
                    case 1:
                        while (validsub)
                        {
                            fondo.instrucciones();
                            validsub = fondo.salirsub(array, stack, arraytemp);
                        }
                        break;
                    case 2:
                        while (validsub)
                        {
                            fondo.calculadora(array, stack, arraytemp);
                            validsub = fondo.salirsub(array, stack, arraytemp);
                        }
                        break;
                    case 3:
                        while (validsub)
                        {
                            fondo.desarrollador();
                            validsub = fondo.salirsub(array, stack, arraytemp);
                        }
                        break;
                    case 4:
                            valid = fondo.salir(array, stack, arraytemp);
                        break;
                    default:
                        Console.WriteLine("Selección invalida, presiona enter para retornar.");
                        fondo.enter();
                        Console.Clear();
                        valid = true;
                        break;
                }
            }
        }
        
    }
}