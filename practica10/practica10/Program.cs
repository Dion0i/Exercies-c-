using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, sum, prom;
            string line;

            Console.Write("Write your firts calification");
            line = Console.ReadLine();
            n1 = int.Parse(line);
            Console.Write("Write your second calification");
            line = Console.ReadLine();
            n2 = int.Parse(line);
            Console.Write("Write your third calification");
            line = Console.ReadLine();
            n3 = int.Parse(line);

            sum = n1 + n2 + n3;
            prom = sum / 3;

            if (prom >= 7) {
                Console.Write("Promocionado");
            }
            Console.ReadKey();

        }
    }
}
