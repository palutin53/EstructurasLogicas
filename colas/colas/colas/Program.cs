using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colas
{
    class popo
    {
        int inicio = 0, final = 0;
        int?[] cola = new int?[10];
        int? temporal;
        int valor;
        public int? peek()
        {
            return cola[inicio];
        }
        public void enque()
        {
            for (int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("ingresa un valor: ");
                valor = int.Parse(Console.ReadLine());
                if (!isFull())
                {
                    while (cola[inicio] != null)
                    {
                        temporal = cola[final];
                        final = final + 1;
                        cola[final] = temporal;
                        final = final - 2;
                    }
                    cola[inicio] = valor;
                }
                else
                {
                    Console.WriteLine("Está lleno.");
                    enter();
                }
            }

        }
        public void dequeue()
        {
            if (!isEmpty())
            {
                cola[final] = null;
                final--;
            }
            else
            {
                Console.WriteLine("Esta vacio.");
                enter();
            }

        }
        public bool isEmpty()
        {
            if (inicio == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool isFull()
        {
            if (final == cola.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void enter()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
        public void mostrar()
        {
            foreach (int? n in cola)
            {
                Console.WriteLine(n);
            }
        }
        public bool salirsub(string[] cola)
        {
            bool validsub = true;
            popo colas = new colas.popo();
            Console.WriteLine("¿Quieres salir?\n 1. Si\n 2. No");
            int salida = int.Parse(Console.ReadLine());
            switch (salida)
            {
                case 1:
                    Console.WriteLine("Presiona enter para salir.");
                    enter();
                    validsub = false;
                    break;
                case 2:
                    Console.WriteLine("Presiona enter para retornar");
                    enter();
                    validsub = true;
                    break;
                default:
                    Console.WriteLine("Valor equivocado, Presiona enter.");
                    enter();
                    validsub = true;
                    break;
            }
            return validsub;
        }
        public bool salir(string[] cola)
        {
            bool valid = true;
            popo colas = new colas.popo();
            Console.WriteLine("¿Quieres salir?\n 1. Si\n 2. No");
            int salida = int.Parse(Console.ReadLine());
            switch (salida)
            {
                case 1:
                    Console.WriteLine("Presiona enter para salir.");
                    enter();
                    valid = false;
                    break;
                case 2:
                    Console.WriteLine("Presiona enter para retornar");
                    enter();
                    valid = true;
                    break;
                default:
                    Console.WriteLine("Valor equivocado, Presiona enter.");
                    enter();
                    valid = true;
                    break;
            }
            return valid;
        }
    }
}
