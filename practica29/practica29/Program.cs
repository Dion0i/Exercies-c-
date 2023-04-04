using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace practica29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f, x,mult;
            string line;
            Console.Write("Write your number");
            line = Console.ReadLine();
            x = int.Parse(line);

            if (x <= 10) 
            {
                for (f = 1; f <= 13; f++) 
                {
                    mult = x * f;
                    Console.WriteLine(mult);
                    Console.Write("_");
                }
            }
            Console.ReadKey();
        }
    }
}
