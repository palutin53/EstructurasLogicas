using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoCodigoTarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arreglos");
            int[] LA = { 1, 3, 5, 7, 8 };
            int k = 3; int n = 5;
            int i, j;

            Console.WriteLine("" + LA[0] + ", " + LA[1] + ", " + LA[2] + ", " + LA[3] + ", " + LA[4]);
            Console.WriteLine("K=" + k + " n=" + n);
            Console.WriteLine("int=i,j");
            Console.ReadKey();

            j = k;
            while (j < n)
            {
                LA[j - 1] = LA[j];
                j = j + 1;

            }
            n = n - 1;

            Console.WriteLine("Desarrollo del arreglo");
            Console.WriteLine("" + LA[0] + ", " + LA[1] + ", " + LA[2] + ", " + LA[3] + ", " + LA[4]);
            Console.ReadKey();
        }
    }
}
