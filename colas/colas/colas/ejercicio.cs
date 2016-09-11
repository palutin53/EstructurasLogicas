using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colas
{
    class ejercicio
    {
        static void Main()
        {
            bool valid = true;
            while (valid) {
                bool validsub = true;
                popo colas = new colas.popo();
                Console.WriteLine("Ingresa un numero depende de lo que quieras hacer.\n 1. enque\n 2. dequeue\n 3. Mostrar\n 4. Salir");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        while (validsub) { colas.enque(); }
                        break;
                    case 2:
                        while (validsub) { colas.dequeue(); }
                        break;
                    case 3:
                        while (validsub) { colas.mostrar(); }
                        break;
                    case 4:
                        
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
