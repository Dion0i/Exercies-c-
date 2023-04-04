using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int f;
            for (f = 1; f <= 10; f++) 
            {
                if (f > 5) 
                {
                     sum += f;
                    Console.Write(f);
                    Console.WriteLine("_");
                }
            }
            Console.Write(sum);

            Console.ReadKey();
        }
    }
}
