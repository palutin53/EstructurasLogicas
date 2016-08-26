using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] popo = new string[5];
            int nav=0;
            double a = 0,x,y;
            int contador = 0, sum=0;
            char signo;
            
                for (nav=0; nav <= 80; nav++)
                {
                    if (contador == 0)
                    {
                        Console.WriteLine("Escribe un numero.");
                        foreach (string s in popo)
                        {
                            Console.Write(s);
                        }
                        x = int.Parse(Console.ReadLine());
                        popo[sum] = Convert.ToString(x);
                        sum++;
                        Console.Clear();
                        Console.WriteLine("ingresa el operador");
                        foreach (string s in popo)
                        {
                            Console.Write(s);
                        }
                        signo = char.Parse(Console.ReadLine());
                        popo[sum] = Convert.ToString(signo);
                        sum++;
                        foreach (string s in popo)
                        {
                        
                            Console.Write(s);
              
                        }
                        Console.Clear();
                        Console.WriteLine("Ingresa un numero");
                        foreach (string s in popo)
                        {
                            Console.Write(s);
                        }
                        y = int.Parse(Console.ReadLine());
                        popo[sum] = Convert.ToString(y);
                        sum++;

                        Console.Clear();
                        switch (signo)
                        {
                            case '+':
                                a = x + y;
                                contador = contador + 1;
                                break;
                            case '-':
                                a = x - y;
                                contador = contador + 1;
                                break;
                            case '*':
                                a = x * y;
                                contador = contador + 1;
                                break;
                            case '/':
                                a = x / y;
                                contador = contador + 1;
                                break;
                            case '=':
                                nav = 80;
                                break;
                            default:
                                break;
                        }
                    }
                    else if (contador == 1)
                    {
                        Console.WriteLine("ingresa el operador");
                        foreach (string s in popo)
                        {
                            Console.Write(s);
                        }
                        signo = char.Parse(Console.ReadLine());
                        popo[sum] = Convert.ToString(signo);
                        sum++;
                        Console.Clear();

                        Console.WriteLine("Ingres un numero");
                        foreach (string s in popo)
                        {
                            Console.Write(s);
                        }
                        y = int.Parse(Console.ReadLine());
                        popo[sum] = Convert.ToString(y);
                        sum++;
                        Console.Clear();

                        switch (signo)
                        {
                            case '+':
                                a = a + y;
                                break;
                            case '-':
                                a = a - y;
                                break;
                            case '*':
                                a = a * y;
                                break;
                            case '/':
                                a = a / y;
                                break;
                            case '=':
                                nav = 80;
                                break;
                            default:

                                break;
                        }
                    }
            }
            foreach (string s in popo)
            {
                Console.Write(s);
            }
            Console.WriteLine("Respuesta: "+a);
            enter();
        }
        static void enter()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter);
        }
    }
}
