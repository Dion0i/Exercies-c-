using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace practica22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            string line;
            int prom;
            int sum = 0;
            int x = 1;

            while (x <= 10) 
            {
                Console.Write("Write the value");
                line = Console.ReadLine();
                value = int.Parse(line);
                sum = sum + value;
                x += 1;
            }
            prom = sum / 10;
            Console.WriteLine(sum);
            Console.WriteLine(prom);

            Console.ReadKey();
        }
    }
}
