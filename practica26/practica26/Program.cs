using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f, value,prom;
            string line;
            int sum = 0;

            for ( f = 1; f <= 10; f++) 
            {
                Console.Write("Write your value");
                line = Console.ReadLine();
                value = int.Parse(line);

                sum += value;
            }
            prom = sum / 10;
            Console.Write(sum);
            Console.Write("-");
            Console.Write(prom);

            Console.ReadKey();
        }
    }
}
