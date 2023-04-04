using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace practica12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, prom;
            string line;

            Console.Write("Write your firts calification");
            line = Console.ReadLine();
            n1 = int.Parse(line);
            // firts
            Console.Write("Write your firts calification");
            line = Console.ReadLine();
            n2 = int.Parse(line);
            // second
            Console.Write("Write your firts calification");
            line = Console.ReadLine();
            n3 = int.Parse(line);
            // third

            prom = (n1 + n2 + n3) / 3;

            if (prom >= 7)
            {
                Console.Write("Promovido");
            }
            else 
            {
                if (prom >= 4)
                {
                    Console.Write("Regular");
                }
                else 
                {
                    Console.Write("Reprobado");
                }
            }
            Console.ReadKey();
        }
    }
}
